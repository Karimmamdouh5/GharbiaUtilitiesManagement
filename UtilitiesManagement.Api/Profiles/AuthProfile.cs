using UtilitiesManagement.Domain.Dtos.Response.Auth;
using UtilitiesManagement.Domain.Models.Permission;

namespace  UtilitiesManagement.Api.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            #region User

            CreateMap<ApplicationUser, AuthUserResponse>()
                .ForMember(d => d.UserName, o
                => o.MapFrom(s => s.Employee.Name))
                .ReverseMap();
            CreateMap<ApplicationUser, UpdateUserRequest>()
                 .ForMember(d => d.User_Id, o
                => o.MapFrom(s => s.Id))
                 .ForMember(d => d.Email, o
                => o.MapFrom(s => s.Email))
                 .ForMember(d => d.UserType_Id, o
                => o.MapFrom(s => s.UserType_Id))
                 .ForMember(d => d.Phone, o
                => o.MapFrom(s => s.PhoneNumber))
                 .ReverseMap();
            CreateMap<ApplicationUser, AuthResigterRequest>()
                .ForMember(d => d.Company_Id , o => o .MapFrom(s => s.CompanyTenantId))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.NormalizedUserName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.NormalizedEmail))
                .ReverseMap();
            CreateMap<ApplicationUser, AuthUserRegisterResponse>()
                .ReverseMap();
            #endregion

            #region PerMenu
            CreateMap<AuthAddPermMenuRequest, PermMenu>()
            .ReverseMap();
            CreateMap<AuthAddPermMenuResponse, PermMenu>()
           .ReverseMap();
            CreateMap<AuthUpdatePermMenuRequest, PermMenu>()
           .ReverseMap();
            CreateMap<PermMenu, PermMenuNodeObject>()
                .ForMember(d => d.ChildNode, o
                => o.MapFrom(s => new List<PermMenuNodeObject>()));
            #endregion
        }

    }
}
