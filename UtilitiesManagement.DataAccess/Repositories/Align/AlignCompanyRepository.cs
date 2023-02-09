namespace  UtilitiesManagement.DataAccess.Repositories.Align
{
    public class AlignCompanyRepository : IAlignCompanyRepository
    {
        private readonly IMapper _mapper;
        private readonly AlignDbContext _context;
        private readonly ILogger _logger;

        public AlignCompanyRepository(AlignDbContext context, ILoggerFactory loggerFactory, IMapper mapper) 
        {

            _mapper = mapper;
            _context=context;
            _logger = loggerFactory.CreateLogger("db_logs");
        }
        public async Task<bool> ExistAsync(Expression<Func<AlignCompany, bool>> filter)
           => await _context.AlignCompanies.AsNoTracking()
               .AnyAsync(filter);

        public async Task<bool> Add(AlignCompany model)
        {
            _context.AlignCompanies.Add(model);
            return await _context.SaveChangesAsync() > 0;
        }

        //public async Task<Response<List<AlignCompanyViewModel>>> GetCompaniesAsync()
        //    => new()
        //    {
        //        IsSuccess = true,
        //        Data = _mapper.Map<List<AlignCompanyViewModel>>(await _context.AlignCompanies.ToListAsync())
        //    };

        //public async Task<Response<string>> UpdateCompanyAsync(List<AlignCompanyViewModel> request)
        //{
        //    var models = await _context.AlignCompanies.Where(x => request.Select(a => a.Id).Contains(x.Id)).ToListAsync();
        //    foreach (var company in models)
        //    {
        //        company.StartDate = request.FirstOrDefault(x => x.Id == company.Id)!.StartDate;
        //        company.EndDate = request.FirstOrDefault(x => x.Id == company.Id)?.EndDate;
        //        company.IsActive = request.FirstOrDefault(x => x.Id == company.Id)!.IsActive;
        //        company.CompanyCode = request.FirstOrDefault(x => x.Id == company.Id)?.CompanyCode;
        //        company.CompanyLink = request.FirstOrDefault(x => x.Id == company.Id)?.CompanyLink;
        //        company.MobileVersion = request.FirstOrDefault(x => x.Id == company.Id)?.MobileVersion;
        //    }

        //    return new Response<string>()
        //    {
        //        IsSuccess = await _context.SaveChangesAsync() > 0
        //    };
        //}

        public async Task<Response<string>> ActiveOrDeActiveCompanyAsync(int id)
        {
            var company = await _context.AlignCompanies.FirstOrDefaultAsync(x => x.Id == id);
            if (company is null)
            {
                return new Response<string>()
                {
                    IsNotFound = true,
                    Message = "Not Found" //_localizer[SDMessages.NotFound]
                };
            }

            company.IsActive = !company.IsActive;
            return new Response<string>()
            {
                IsSuccess = await _context.SaveChangesAsync() > 0
            };
        }


        public async Task<Response<string>> ActiveOrDeActiveCompanyAsync(string code, bool status)
        {
            var company = await _context.AlignCompanies.FirstOrDefaultAsync(x => x.CompanyCode == code);
            if (company is null)
            {
                return new Response<string>()
                {
                    IsNotFound = true,
                    Message = "Not Found" //_localizer[SDMessages.NotFound]
                };
            }

            company.IsActive = status;
            return new Response<string>()
            {
                IsSuccess = await _context.SaveChangesAsync() > 0
            };
        }

        public async Task<Response<CompanyConfigurationResponse>> GetCompanyLinkAndVersionAsync(string code)
        {
            var company = (await _context.AlignCompanies.FirstOrDefaultAsync(x => x.CompanyCode == code));

            return new Response<CompanyConfigurationResponse>()
            {
                Data = new CompanyConfigurationResponse() { CompanyLink = company.CompanyLink, MobileVersion = company.MobileVersion,DownloadUrl=company.DownloadUrl,VersionCode=company.VersionCode,VersionDate=company.VersionDate },
                IsSuccess = true
            };
        }

    }
}
