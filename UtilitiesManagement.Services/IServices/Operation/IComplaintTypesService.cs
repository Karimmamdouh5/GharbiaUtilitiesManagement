namespace  UtilitiesManagement.Services.IServices.Operation
{
    public interface IComplaintTypesService
    {
        #region Complaint Types
        Task<Response<IEnumerable<SelectListComplaintTypeResponse>>> GetAllComplaintTypesAsync();
        Task<Response<AddComplaintTypeRequest>> AddComplaintTypeAsync(AddComplaintTypeRequest addComplaintTypeRequest);
        Task<Response<UpdateComplaintTypeRequest>> UpdateComplaintTypeAsync(int complaintTypeId, UpdateComplaintTypeRequest updateComplaintTypeRequest);
        Task<Response<string>> DeleteComplaintTypeAsync(int complaintTypeId);
        #endregion
    }
}