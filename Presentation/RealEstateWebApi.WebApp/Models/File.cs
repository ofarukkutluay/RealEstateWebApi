using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateWebApi.WebApp.Models
{
    public class File
    {
        public uint Id { get; set; }         
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }

        [NotMapped]
        public string FullPath { get => $"{Path}/{FileName}"; }
    }
}
