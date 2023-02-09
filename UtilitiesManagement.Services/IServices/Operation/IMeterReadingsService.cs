namespace  UtilitiesManagement.Services.IServices.Operation
{
    public interface IMeterReadingsService
    {
        #region Meter readings
        Task<Response<GetMeterReadingResponse>> GetAllMeterReadingsAsync(SearchParametersForMeterReadingsRequest searchParametersRequest);
        Task<Response<IEnumerable<AddMeterReadingRequest>>> AddMeterReadingAsync(IEnumerable<AddMeterReadingRequest> addMeterReadingRequests);
        Task<Response<IEnumerable<UpdateMeterReadingRequest>>> UpdateTwoSpecificFieldsForMeterReadingAsync(IEnumerable<UpdateMeterReadingRequest> updateMeterReadingRequests);
        Task<Response<IEnumerable<string>>> UploadMeterReadingImageAsync(List<IFormFile> photos, ImagePathRequest imagePath);
        Task<Response<IEnumerable<SelectListResponse>>> ListOfMeterReadingStatusAsync();
        Task<Response<UpdateMeterReadingValueRequest>> UpdateMeterReadingValueAsync(UpdateMeterReadingValueRequest model);
        #endregion
    }
}