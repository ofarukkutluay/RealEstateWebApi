using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Infrastructure.Services.Storage.Local
{
    public class LocalStorage : Storage, IStorage
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LocalStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        private string WebRootPath { get=> _webHostEnvironment.WebRootPath;}
        private string Storage { get => "Local"; }

        public Task<bool> DeleteAsync(string directory, string fileName)
        {
            string path = Path.Combine(WebRootPath, directory, fileName);
            File.Delete(path);
            return Task.FromResult(true);
        }

        public Task<List<string>> GetFilesAsync(string directory)
        {
            var result = Task.Run(() =>
            {
                string path = Path.Combine(WebRootPath, directory);
                DirectoryInfo directoryInfo = new(path);
                return directoryInfo.GetFiles().Select(f => f.Name).ToList();
            });
            return result;
        }

        public async Task<FilePath> MoveFileAsync(string directory, string fileName, string newDirectory)
        {
            string path = Path.Combine(WebRootPath, directory, fileName);
            string newPath = Path.Combine(WebRootPath, newDirectory);
            string fileNewName = await FileRenameAsync(newPath, fileName, HasFile);
            string movePath = Path.Combine(WebRootPath, newDirectory, fileNewName);

            File.Move(path, movePath);

            return new FilePath(newDirectory, fileNewName,Storage);
        }

        async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);

                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                //todo log!
                throw ex;
            }
        }

        public async Task<List<FilePath>> UploadAsync(string directory, IFormFileCollection formFiles)
        {
            
            string pathDirectory = Path.Combine(WebRootPath, directory);
            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            List<FilePath> datas = new List<FilePath>();
            foreach (IFormFile file in formFiles)
            {
                string fileNewName = await FileRenameAsync(pathDirectory, file.FileName, HasFile);
                string path = Path.Combine(pathDirectory, fileNewName);
                await CopyFileAsync(pathDirectory, file);
                datas.Add(new FilePath(directory, fileNewName, Storage));
            }



            return datas;
        }

        public async Task<FilePath> UploadSingleAsync(string directory, IFormFile formFile)
        {

            string pathDirectory = Path.Combine(WebRootPath, directory);
            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            string fileNewName = await FileRenameAsync(pathDirectory, formFile.FileName, HasFile);
            string path = Path.Combine(pathDirectory, fileNewName);
            await CopyFileAsync(path, formFile);

            return new FilePath(directory, fileNewName, Storage);
        }

        public bool HasFile(string directory, string fileName)
        {
            string path = Path.Combine(directory, fileName);
            return File.Exists(path);
        }

    }
}
