using GharbiaUtilitiesManagement.Domain.Models.Shared;
using GharbiaUtilitiesManagement.Domain.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IMainBillsTempRepository : IBaseRepository<SharMainTable_Bills>
    {
        public Task<List<SharMainTable_Bills_ViewModel>> LoadBillTemp();
        public Task<bool> DeleteAllData();
        public Task<bool> SetRestOfData();
    }
}
