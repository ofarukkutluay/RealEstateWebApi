using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Storage
{
    public interface IStorage
    {
        Task<List<FilePath>> UploadAsync(string directoryOrContainer, IFormFileCollection formFiles);
        Task<FilePath> UploadSingleAsync(string directory, IFormFile formFile);
        Task<FilePath> MoveFileAsync(string directoryOrContainer, string fileName, string moveDirectoryOrContainer);
        Task<bool> DeleteAsync(string directoryOrContainer, string fileName);
        Task<List<string>> GetFilesAsync(string directoryOrContainer);
        bool HasFile(string directoryOrContainer, string fileName);

    }
}
