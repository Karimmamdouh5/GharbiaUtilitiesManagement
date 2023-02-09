
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Extensions.Auth;

namespace  UtilitiesManagement.DataAccess.Repositories.Align
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly AlignDbContext _context;
        private readonly ILogger _logger;
        public LoggingRepository(AlignDbContext context, ILoggerFactory loggerFactory, IMapper mapper,
                                     IHttpContextAccessor accessor)
        {
            _accessor = accessor;
            _mapper = mapper;
            _context = context;
            _logger = loggerFactory.CreateLogger("db_logs");
        }
      

        public async Task<bool> LogExceptionInDb(Exception exception, string objJson = null, LogType logType= LogType.Bug)
        {
            try
            {
                await _context.Logging.AddAsync(new Logging()
                {
                    Message = exception?.Message ?? "",
                    ExceptionPath = exception?.Source ?? "",
                    ExceptionInnerPath = exception?.InnerException?.Source ?? "",
                    InnerException = exception?.InnerException?.Message ?? "",
                    StackTrace = exception?.StackTrace ?? "",
                    ObjJson = objJson,
                    InsertBy = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId()
                }) ;
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                var obj = JsonConvert.SerializeObject(e);
                _logger.LogError(obj);
                throw;
            }

        }

    }
}
