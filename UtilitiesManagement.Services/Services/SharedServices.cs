using UtilitiesManagement.Domain.Constants;
using UtilitiesManagement.Domain.Dtos;
using UtilitiesManagement.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.Services
{
    public class SharedServices : ISharedServices
    {
        private readonly IStringLocalizer<PermissionsResources> _permLocalizer;
        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SharedServices(IStringLocalizer<PermissionsResources> permLocalizer,
            IHttpContextAccessor accessor, IMapper mapper,
            IUnitOfWork unitOfWork
                             )
        {
            _permLocalizer = permLocalizer;
            _accessor = accessor;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public List<AuthPermissionsTreeResponse> CreatePermissionsTree(List<TreeObject> TreeData)
        {

            var Counter = 0;
            var Data = new AuthPermissionsTreeResponse();
            if (TreeData.Select(x => x.PermissionItem).ToList().Count == 0)
            {
                return new List<AuthPermissionsTreeResponse>();
            }
            var SplittedClaims = TreeData.Select(x => x.PermissionItem).Select(x => x.Split(".")).ToList();
            var ScreenTypes = SplittedClaims.Select(x => x[0]).Distinct().Select(y => new AuthPermissionsTreeResponse()
            {
                Children = new List<AuthPermissionsTreeResponse>(),
                Id = 0,
                IsSelected = false,
                Name = y
            }
            ).ToList();
            var ParentModules = SplittedClaims.Select(x => x[1]).Distinct().ToList();
            var Modules = SplittedClaims.Select(x => x[2]).Distinct().ToList();
            foreach (var SplittedClaimsItem in SplittedClaims)
            {
                if (!Data.Children.Any(x => x.Name == SplittedClaimsItem[0]))
                {
                    Data.Children.Add(new AuthPermissionsTreeResponse()
                    {
                        Children = new List<AuthPermissionsTreeResponse>(),
                        Name = SplittedClaimsItem[0],
                        Name_Ar=_permLocalizer[SplittedClaimsItem[0]],
                        Id = 0,
                        IsSelected = false
                    });
                }
                if (Data.Children.Where(x => x.Name == SplittedClaimsItem[0] && x.Children.Any(z => z.Name == SplittedClaimsItem[1])).SingleOrDefault() == null)
                {
                    Data.Children.Where(x => x.Name == SplittedClaimsItem[0]).SingleOrDefault()!.Children.Add(new AuthPermissionsTreeResponse()
                    {
                        Children = new List<AuthPermissionsTreeResponse>(),
                        Name = SplittedClaimsItem[1],
                        Name_Ar=_permLocalizer[SplittedClaimsItem[1]],
                        Id = 0,
                        IsSelected = false
                    });
                }
                if (Data.Children.Where(x => x.Name == SplittedClaimsItem[0] && x.Children.Any(z => z.Name == SplittedClaimsItem[1]) && x.Children.Where(t => t.Name == SplittedClaimsItem[1]).SingleOrDefault()!.Children.Any(i => i.Name == SplittedClaimsItem[2])).SingleOrDefault() == null)
                {
                    Data.Children.Where(x => x.Name == SplittedClaimsItem[0]).SingleOrDefault()!.Children.Where(y => y.Name == SplittedClaimsItem[1]).SingleOrDefault()!.Children.Add(new AuthPermissionsTreeResponse()
                    {
                        Children = new List<AuthPermissionsTreeResponse>(),
                        Id = 0,
                        IsSelected = false,
                        Name = SplittedClaimsItem[2],
                        Name_Ar=_permLocalizer[SplittedClaimsItem[2]],
                    });
                }
                Data.Children.Where(x => x.Name == SplittedClaimsItem[0]).SingleOrDefault()!.Children.Where(y => y.Name == SplittedClaimsItem[1]).SingleOrDefault()!.Children.Where(z => z.Name == SplittedClaimsItem[2]).SingleOrDefault()!.Children.Add(new AuthPermissionsTreeResponse()
                {
                    Children = null,
                    Id = TreeData.Select(x => x.RoleClaimsId).ToList()[Counter],
                    IsSelected = TreeData.Select(x => x.RoleClaimsSelectedFlag).ToList()[Counter],
                    Name = SplittedClaimsItem[3],
                    Name_Ar=_permLocalizer[SplittedClaimsItem[3]],
                    
                });
                Counter++;
            }
            return Data.Children; 
        }

        public List<CheckBox> GetPermissionsFromTree(List<AuthPermissionsTreeResponse> Tree)
        {
            var Permissions = new List<CheckBox>();
            foreach (var ScreenTypeNode in Tree)
            {
                foreach (var ParentModule in ScreenTypeNode.Children)
                {
                    foreach (var Module in ParentModule.Children)
                    {
                        foreach (var Action in Module.Children)
                        {
                            Permissions.Add(new CheckBox()
                            {
                                DisplayValue = ScreenTypeNode.Name + "." + ParentModule.Name + "." + Module.Name + "." + Action.Name,
                                Id = Action.Id,
                                IsSelected = Action.IsSelected
                            });
                        }
                    }
                }
            }
            return Permissions;
        }
        public async Task<List<PermMenuNodeObject>> GetMenu()
        {
            try
            {
                var TokenPerms = _accessor.HttpContext.User.Claims.Where(x => x.Type == "Permission" && (x.Value.Split(".")[3] == "Full" || x.Value.Split(".")[3] == "View")).Select(x => x.Value).ToList();
                var PermissionsItems = TokenPerms.Select(x => x.Split(".")[0] + "." + x.Split(".")[1] + "." + x.Split(".")[2] + "." + "View").ToList();

                var LastChildern = _unitOfWork.PermMenu.GetAll(filter: x => PermissionsItems.Any(y => y == x.Permission), ignoreQueryFilters: true).ToList();


                //var AllPermMenuRecord = (await _unitOfWork.PermMenu.GetAllAsync(filter: x => true, ignoreQueryFilters: true)).ToList();
                var Chains = new List<PermMenu>();
                Chains.AddRange(LastChildern);
                foreach (var childItem in LastChildern)
                {

                    var parentItem = await _unitOfWork.PermMenu.GetFirstOrDefaultAsync(filter: x => x.Id == childItem.ParentId);
                    Chains.Add(parentItem);
                    while (parentItem != null && parentItem.ParentId != null)
                    {
                        parentItem = await _unitOfWork.PermMenu.GetFirstOrDefaultAsync(filter: x => x.Id == parentItem.ParentId);
                        Chains.Add(parentItem);
                    }
                }
                //while (LastChildern.Count(x => x.ParentId == null) != 2)
                //{
                //    var WorkingList = LastChildern.Select(x => x).ToList();
                //    foreach (var ChildrenListItem in LastChildern)
                //    {
                //        WorkingList.AddRange(AllPermMenuRecord.Where(x => x.Id == ChildrenListItem.ParentId).ToList());
                //    }
                //    LastChildern = WorkingList.Distinct().Select(x => x).ToList();
                //}
                // var tree = RawCollectionToTree(LastChildern).ToList();
                var tree = RawCollectionToTree(Chains.Distinct().ToList()).ToList();
                return tree;
            }
            catch (Exception ex)
            {
                return new List<PermMenuNodeObject>();
            }
        }
        public IEnumerable<PermMenuNodeObject> RawCollectionToTree(List<PermMenu> collection)
        {
            var treeDictionary = new Dictionary<int?, PermMenuNodeObject>();

            collection.Where(x => x != null).DistinctBy(x => x.Id).ToList().ForEach(x => { treeDictionary.Add(x.Id, _mapper.Map<PermMenuNodeObject>(x)); });

            foreach (var item in treeDictionary.Values.OrderBy(x => x.OrderBy))
            {
                if (item.ParentId != null)
                {
                    PermMenuNodeObject proposedParent;

                    if (treeDictionary.TryGetValue((int)item.ParentId, out proposedParent))
                    {
                        item.Parent = proposedParent;
                        proposedParent.ChildNode.Add(item);
                    }
                }

            }
            return treeDictionary.Values.Where(x => x.Parent == null && x.ParentId == null);
        }
    }
}
