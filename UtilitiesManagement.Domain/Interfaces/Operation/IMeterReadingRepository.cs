namespace  UtilitiesManagement.Domain.Interfaces.Operation
{
    public interface IMeterReadingRepository : IBaseRepository<OprMeterReading>
    {
        Task<bool> Remote_PostMeterReading(string cstomer_Name , string CustomerId , long issurDetails_Id, string meterStates, double readingValue, string notes, long collectorId, string userName, long deviceId, long BlockId);
        Task<IEnumerable<PreviousReadingForCustomer_ViewModel>> GetRemotePreviousReadingForCustomersAsync(string CustomerIds, string issueDates);
    }
}
