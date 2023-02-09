using UtilitiesManagement.Domain.Constants;
using UtilitiesManagement.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Response.Auth;

namespace  UtilitiesManagement.Services.IServices
{
    public interface ISharedServices
    {
        List<AuthPermissionsTreeResponse> CreatePermissionsTree(List<TreeObject> TreeData);
        List<CheckBox> GetPermissionsFromTree(List<AuthPermissionsTreeResponse> Tree);
        Task<List<PermMenuNodeObject>> GetMenu();
        IEnumerable<PermMenuNodeObject> RawCollectionToTree(List<PermMenu> collection);
    }
}
