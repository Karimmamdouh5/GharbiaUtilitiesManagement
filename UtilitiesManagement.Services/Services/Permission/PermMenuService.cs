using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Services.IServices;

namespace UtilitiesManagement.Services.Services.Permission
{
    public class PermMenuService : IPermMenuService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _context;
        private readonly ISharedServices _sharedServices;
        public PermMenuService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer, ILoggingRepository loggingRepository, IMapper mapper, IHttpContextAccessor context , ISharedServices sharedServices)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _context = context;
            _sharedServices = sharedServices;
        }

        public async Task<Response<AuthAddPermMenuResponse>> AddPermMunu(AuthAddPermMenuRequest model)
        {
            try
            {
                var PermMenuItem = _mapper.Map<PermMenu>(model);
                if ((bool)PermMenuItem.IsLast)
                {
                    if (PermMenuItem.Permission.Split(".")[3] != "View")
                    {
                        return new Response<AuthAddPermMenuResponse>()
                        {
                            Message = _sharLocalizer[SDLocalization.RefusedPermission],
                            IsSuccess = false
                        };
                    }
                }

                var Data = await _unitOfWork.PermMenu.AddAsync(PermMenuItem);
                await _unitOfWork.CompleteAsync();
                return new Response<AuthAddPermMenuResponse>
                {
                    Data = _mapper.Map<AuthAddPermMenuResponse>(Data),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Done]
                };
            }
            catch (Exception ex)
            {
                return new Response<AuthAddPermMenuResponse>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<List<PermMenuNodeObject>>> GetAdminMenu()
        {
            try
            {
                var PermMenuRecords =( await _unitOfWork.PermMenu.GetAllAsync(filter:x=> true, ignoreQueryFilters: true)).ToList();
                var tree = _sharedServices.RawCollectionToTree(PermMenuRecords).ToList();
                return new Response<List<PermMenuNodeObject>>()
                {
                    Data = tree,
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Response<List<PermMenuNodeObject>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    IsSuccess = false,
                    Errors = new[] { ex.Message }
                };
            }
        }


        
        public async Task<Response<List<string>>> GetMenuPermissions()
        {
            try
            {
                var ResultTree = new List<PermMenuNodeObject>();
                var TokenPerms = _context.HttpContext.User.Claims.Where(x => x.Type == "Permission" && (x.Value.Split(".")[3] == "Full" || x.Value.Split(".")[3] == "View")).Select(x => x.Value).ToList().Distinct();
                return new Response<List<string>>()
                {
                    Data = TokenPerms.Select(x => x.Split(".")[0] + "." + x.Split(".")[1] + "." + x.Split(".")[2] + "." + "View").ToList(),
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Response<List<string>>()
                {
                    Errors = new[] {ex.Message},
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }   
        }

        public async Task<Response<string>> RemovePermMunu(int Id)
        {
            try
            {
                var SearchedPermMenu = await _unitOfWork.PermMenu.GetFirstOrDefaultAsync(filter: x => x.Id == Id);
                await _unitOfWork.PermMenu.Remove(SearchedPermMenu);
                await _unitOfWork.CompleteAsync();
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Deleted],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    IsSuccess = false,
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<AuthUpdatePermMenuRequest>> UpdatePermMunu(AuthUpdatePermMenuRequest model)
        {
            try
            {
                if ((bool)model.IsLast)
                {
                    if (model.Permission.Split(".")[3] != "View")
                    {
                        return new Response<AuthUpdatePermMenuRequest>()
                        {
                            Message = _sharLocalizer[SDLocalization.RefusedPermission],
                            IsSuccess = false
                        };
                    }
                }
               
                var SearchedItem = await _unitOfWork.PermMenu.GetFirstOrDefaultAsync(filter: x => x.Id == model.Id);
                var WorkingSearchedItem = _mapper.Map(model, SearchedItem);

                var Data = _unitOfWork.PermMenu.Update(WorkingSearchedItem);
                await _unitOfWork.CompleteAsync();
                return new Response<AuthUpdatePermMenuRequest>
                {
                    Data = _mapper.Map<AuthUpdatePermMenuRequest>(Data),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Updated]
                };
            }
            catch (Exception ex)
            {
                return new Response<AuthUpdatePermMenuRequest>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }
        public async Task<Response<string>> ChangeActivation(int[] NodesIds)
        {
            try
            {
                var GelPermMenus = (_unitOfWork.PermMenu.GetAll(filter: x => NodesIds.Contains(x.Id), ignoreQueryFilters: true)).ToList();
                if (GelPermMenus.Count() == 0)
                {
                    return new Response<string>()
                    {
                        Data = _sharLocalizer[SDLocalization.NotFoundData],
                        Message = _sharLocalizer[SDLocalization.NotFoundData],
                        IsSuccess = false
                    };
                }
                GelPermMenus.ForEach(x => { x.IsDeleted = !x.IsDeleted; });
                _unitOfWork.PermMenu.UpdateRange(GelPermMenus);
                _unitOfWork.Complete();
                return new Response<string>()
                {
                    Data = GelPermMenus.FirstOrDefault().IsDeleted ? _sharLocalizer[SDLocalization.DeActivated] : _sharLocalizer[SDLocalization.Activated],
                    Message = GelPermMenus.FirstOrDefault().IsDeleted ? _sharLocalizer[SDLocalization.DeActivated] : _sharLocalizer[SDLocalization.Activated],
                    IsSuccess = true,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                return new Response<string>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error],
                    IsSuccess = false
                };
            }
        }

        public async Task<Response<List<PermMenuNodeObject>>> GetMenu()
        {
            var data = await _sharedServices.GetMenu();
            return new Response<List<PermMenuNodeObject>>() { Data = data, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
        }
    }
}
