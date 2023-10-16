namespace LR_7.Models.File
{
    public class FileForDownload
    {
        public List<byte> Contents { get; set; } = new List<byte>();
        public string Name { get; set; } = String.Empty;
    }
}
