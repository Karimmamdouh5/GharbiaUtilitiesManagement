using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Permission
{
    public interface IPermMenuService
    {
        Task<Response<AuthAddPermMenuResponse>> AddPermMunu(AuthAddPermMenuRequest model);
        Task<Response<string>> RemovePermMunu(int Id);
        Task<Response<AuthUpdatePermMenuRequest>> UpdatePermMunu(AuthUpdatePermMenuRequest model);
        //Task<Response<List<PermMenuNodeObject>>> GetMenu();
        Task<Response<List<PermMenuNodeObject>>> GetMenu();
        Task<Response<List<PermMenuNodeObject>>> GetAdminMenu();
        Task<Response<List<string>>> GetMenuPermissions();
        Task<Response<string>> ChangeActivation(int[] NodesIds);
    }
}
