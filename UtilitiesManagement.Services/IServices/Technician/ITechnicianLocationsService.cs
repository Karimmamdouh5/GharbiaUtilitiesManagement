namespace UtilitiesManagement.Services.IServices.Technician
{
    public interface ITechnicianLocationsService
    {
        Task<Response<IEnumerable<SharSearchForLocationResponse>>> GetAllLocationsByFilterationForTechnicianAsync(SharSearchForLocationRequest searchForLocationRequest);
        Task<Response<IEnumerable<TechGetLastTechnician>>> getTechnicianLogs(int EmployeeId);
        Task<Response<List<AuthLatestLocationForUserResponse>>> GetLastLocationToUserAsync(List<long> empsIds);
        Task<Response<IEnumerable<TechTechnicianLocationRequest>>> AddTechniciansLocations(List<TechTechnicianLocationRequest> technicianLocationRequest);
        Task<Response<TechGetLastTechnician>> GetLastRecordTechnician(int EmployeeId);
        Task<Response<AddTechnicianLogRequest>> AddNewTechnicianLog(AddTechnicianLogRequest model);
        Task<Response<string>> StopTechnician(int employeeId);
    }
}
