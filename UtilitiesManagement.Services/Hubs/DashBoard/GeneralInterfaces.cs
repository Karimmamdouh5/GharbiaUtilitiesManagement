using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.Hubs.DashBoard
{
    public interface GeneralInterfaces
    {
        Task LoadData(string LoadData);
        Task LoadBills(string LoadBills);
    }
}
