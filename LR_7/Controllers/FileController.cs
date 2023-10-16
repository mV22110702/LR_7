using LR_7.Models;
using LR_7.Models.File;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.IO;
using LR_7.Services.File;

namespace LR_7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : Controller
    {
        private FileService FileService { get; set; }

        public FileController(FileService FileService)
        {
            this.FileService = FileService;
        }

        [HttpGet("[action]")]
        public IActionResult DownloadFile()
        {

            return View();
        }

        [HttpPost("[action]")]
        public FileResult DownloadFile([FromForm] DownloadFileFormModel formModel)
        {
            FileForDownload file = FileService.DownloadFile(formModel);
            return File(file.Contents.ToArray(), "text/plain", file.Name);
        }
    }
}