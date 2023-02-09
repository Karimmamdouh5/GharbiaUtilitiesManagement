

namespace UtilitiesManagement.Domain.Interfaces.Technician
{
    public interface ITechnicianRepository : IBaseRepository<TechTechnician>
    {
        /// <summary>
        /// Function Returns list of technicians of the employee
        /// </summary>
        /// <param name="EmployeeId">Id of the employee data type of (INT)</param>
        /// <returns>list of technicians data type (List<GetListResponse>)</returns>
        
    }
}
