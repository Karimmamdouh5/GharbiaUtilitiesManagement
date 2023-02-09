namespace  UtilitiesManagement.Services.Services.AppConfig
{
    public class FileUploader : IFileUploader
    {
        public FileUploader(){}

        public string ProcessUploadedFile(IFormFile photo, string pathFolder, IWebHostEnvironment hostEnvironment, string? fileName)
        {
            //var baseUrl = 
            //    $"{_accessor.HttpContext.Request.Scheme}://{_accessor.HttpContext.Request.Host.ToUriComponent()}";

            //var result = pathFolder.Split("StaticFiles");
            //string path = hostEnvironment.ContentRootPath + "MyStaticFiles" + result[1];
            //string pathDb = hostEnvironment.ContentRootPath + pathFolder;
            string path = hostEnvironment.ContentRootPath + pathFolder;
            string uniqueFileName = String.IsNullOrEmpty(fileName) ? DateTime.UtcNow.AddHours(2).ToString("ddMMyyyyHHmmssff") + photo.FileName : fileName+ DateTime.UtcNow.AddHours(2).ToString("ddMMyyHHmmssff") + System.IO.Path.GetExtension(photo.FileName);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (FileStream fileStream = File.Create(path + uniqueFileName))
            {
                photo.CopyTo(fileStream);
                fileStream.Flush();
            }
            uniqueFileName = pathFolder + uniqueFileName;
            return uniqueFileName;
        }

        public List<string> ProcessUploadedFiles(List<IFormFile> photos, string pathFolder, IWebHostEnvironment hostEnvironment)
        {
            //var baseUrl = 
            //    $"{_accessor.HttpContext.Request.Scheme}://{_accessor.HttpContext.Request.Host.ToUriComponent()}";

            //var result = pathFolder.Split("StaticFiles");
            //string path = hostEnvironment.ContentRootPath + "MyStaticFiles" + result[1];
            //string pathDb = hostEnvironment.ContentRootPath + pathFolder;

            string path = hostEnvironment.ContentRootPath + pathFolder;
            List<string> uniqueFileNames = new List<string>();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach (var photo in photos)
            {
                var fileName = DateTime.UtcNow.AddHours(2).ToString("ddMMyyyyHHmmssff") + photo.FileName;

                using (FileStream fileStream = File.Create(path + fileName))
                {
                    photo.CopyTo(fileStream);
                    fileStream.Flush();
                }
                uniqueFileNames.Add(pathFolder + fileName);
            }

            return uniqueFileNames;
        }

        public bool DeleteFile(string Path, IWebHostEnvironment hostEnvironment)
        {
            try
            {
                var FilePath = hostEnvironment.ContentRootPath + Path;
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
