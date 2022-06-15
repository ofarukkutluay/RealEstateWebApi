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

        public Task<bool> DeleteAsync(string directory, string fileName)
        {
            string path = Path.Combine(directory, fileName);
            File.Delete(path);
            return Task.FromResult(true);
        }

        public Task<List<string>> GetFilesAsync(string directory)
        {
            var result = Task.Run(() =>
            {
                DirectoryInfo directoryInfo = new(directory);
                return directoryInfo.GetFiles().Select(f => f.Name).ToList();
            });
            return result;
        }

        public async Task<FilePath> MoveFileAsync(string directory, string fileName, string newDirectory)
        {
            string path = Path.Combine(directory, fileName);
            string fileNewName = await FileRenameAsync(newDirectory, fileName, HasFile);
            string movePath = Path.Combine(newDirectory, fileNewName);

            File.Move(path, movePath);

            return new FilePath(newDirectory, fileNewName);
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
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            List<FilePath> datas = new List<FilePath>();
            foreach (IFormFile file in formFiles)
            {
                string fileNewName = await FileRenameAsync(directory, file.FileName, HasFile);
                string path = Path.Combine(directory, fileNewName);
                await CopyFileAsync(path, file);
                datas.Add(new FilePath(directory, fileNewName));
            }



            return datas;
        }

        public async Task<FilePath> UploadSingleAsync(string directory, IFormFile formFile)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string fileNewName = await FileRenameAsync(directory, formFile.FileName, HasFile);
            string path = Path.Combine(directory, fileNewName);
            await CopyFileAsync(path, formFile);

            return new FilePath(directory, fileNewName);
        }

        public bool HasFile(string directory, string fileName)
        {
            string path = Path.Combine(directory, fileName);
            return File.Exists(path);
        }
    }
}
