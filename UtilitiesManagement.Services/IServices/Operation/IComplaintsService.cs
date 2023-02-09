namespace  UtilitiesManagement.Services.IServices.Operation
{
    public interface IComplaintsService
    {
        #region Complaints
        Task<Response<GetComplaintResponse>> GetAllComplaintsAsync(SearchParametersRequest searchParametersRequest);
        Task<Response<IEnumerable<AddComplaintRequest>>> AddComplaintAsync(IEnumerable<AddComplaintRequest> addComplaintRequests);
        Task<Response<IEnumerable<UpdateComplaintRequest>>> UpdateSpecificFieldForComplaintAsync(List<UpdateComplaintRequest> updateComplaintRequests);
        Task<Response<IEnumerable<string>>> UploadComplaintImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath,string? internet_Speed);
        #endregion
    }
}