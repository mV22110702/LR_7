using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LR_7.Models.File
{
    public class DownloadFileFormModel
    {
        [BindRequired]
        public FileDetails File { get; set; }
        [BindRequired]
        public User User { get; set; }
    }
}
