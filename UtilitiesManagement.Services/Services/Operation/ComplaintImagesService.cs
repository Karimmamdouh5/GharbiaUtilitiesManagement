namespace UtilitiesManagement.Services.Services.Operation
{
    public class ComplaintImagesService : IComplaintImagesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;

        public ComplaintImagesService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                     ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        #region Complaints images
        #endregion
    }

}