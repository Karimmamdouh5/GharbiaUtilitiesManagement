namespace UtilitiesManagement.Services.IServices.Shared
{
    public interface IAreaService
    {
        Task<Response<IEnumerable<ListOfAreasResponse>>> GetAreasAsync(int? cityId, int? employeeId);
        Task<bool> ManageAreasDataAsync();
    }
}
