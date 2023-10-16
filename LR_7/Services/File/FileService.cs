using LR_7.Controllers;
using LR_7.Models.File;
using System.Text;

namespace LR_7.Services.File
{
    public class FileService
    {
        private readonly ILogger<FileController> _logger;

        public FileService(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        public FileForDownload DownloadFile(DownloadFileFormModel formModel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(formModel.User.Name);
            stringBuilder.AppendLine(formModel.User.Surname);
            List<byte> fileContents = Encoding.UTF8.GetBytes(stringBuilder.ToString()).ToList();
            string textFileName = formModel.File.Name.Contains(".txt") ? formModel.File.Name : $"{formModel.File.Name}.txt";
            _logger.LogInformation($"{textFileName} created.");
            return new FileForDownload() { Contents = fileContents, Name = textFileName };
        }
    }
}
