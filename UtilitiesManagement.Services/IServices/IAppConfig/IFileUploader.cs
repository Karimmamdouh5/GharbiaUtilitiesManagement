using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace  UtilitiesManagement.Services.IServices.IAppConfig
{
    public interface IFileUploader
    {
        string ProcessUploadedFile(IFormFile photo, string pathFolder, IWebHostEnvironment hostEnvironment, string? fileName);
        List<string> ProcessUploadedFiles(List<IFormFile> photos, string pathFolder, IWebHostEnvironment hostEnvironment);
        bool DeleteFile(string pathFolder, IWebHostEnvironment hostEnvironment);

    }
}
