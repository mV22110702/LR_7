using LR_7.Models;
using LR_7.Models.File;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace LR_7.Controllers
{
    [ApiController]
    [Route("File")]
    public class FileController : Controller
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpGet("DownloadFile")]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost("DownloadFile")]
        public FileResult DownloadFile([FromForm] DownloadFileFormModel formModel)
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.AppendLine(formModel.User.Name);
            stringBuilder.AppendLine(formModel.User.Surname);
            byte[] fileContents = Encoding.UTF8.GetBytes(stringBuilder.ToString());
            string textFileName = formModel.File.Name.Contains(".txt") ? formModel.File.Name : $"{formModel.File.Name}.txt";
            return File(fileContents, "text/plain", textFileName);
        }
    }
}