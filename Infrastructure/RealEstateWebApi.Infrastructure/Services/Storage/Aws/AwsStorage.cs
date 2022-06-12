using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Infrastructure.Services.Storage.Aws
{
    public class AwsStorage : Storage, IStorage
    {
        public Task<bool> DeleteAsync(string directoryOrContainer, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetFilesAsync(string directoryOrContainer)
        {
            throw new NotImplementedException();
        }

        public Task<FilePath> MoveFileAsync(string directoryOrContainer, string fileName, string moveDirectoryOrContainer)
        {
            throw new NotImplementedException();
        }

        public Task<List<FilePath>> UploadAsync(string directoryOrContainer, IFormFileCollection formFiles)
        {
            throw new NotImplementedException();
        }

        bool IStorage.HasFile(string directoryOrContainer, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
