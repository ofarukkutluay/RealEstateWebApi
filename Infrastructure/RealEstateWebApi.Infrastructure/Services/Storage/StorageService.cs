using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Infrastructure.Services.Storage
{
    public class StorageService : IStorageService
    {
        private readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public string StorageName { get => _storage.GetType().Name; }

        public async Task<bool> DeleteAsync(string directoryOrContainer, string fileName)
            => await _storage.DeleteAsync(directoryOrContainer, fileName);

        public async Task<List<string>> GetFilesAsync(string directoryOrContainer)
            => await _storage.GetFilesAsync(directoryOrContainer);

        public bool HasFile(string directoryOrContainer, string fileName)
            => _storage.HasFile(directoryOrContainer, fileName);

        public async Task<FilePath> MoveFileAsync(string directoryOrContainer, string fileName, string moveDirectoryOrContainer)
            => await _storage.MoveFileAsync(directoryOrContainer, fileName, moveDirectoryOrContainer);

        public async Task<List<FilePath>> UploadAsync(string directoryOrContainer, IFormFileCollection formFiles)
            => await _storage.UploadAsync(directoryOrContainer, formFiles);

        public async Task<FilePath> UploadSingleAsync(string directory, IFormFile formFile)
            => await _storage.UploadSingleAsync(directory,formFile);
    }
}
