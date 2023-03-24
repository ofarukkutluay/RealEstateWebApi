using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RealEstateWebApi.Infrastructure.Services.Storage.Aws
{
    public class AwsStorage : Storage, IStorage
    {
        private IAmazonS3 client;
        const string ACCESS_KEY_ID = "";
        const string SECRET_ACCESS_KEY = "";
        const string BUCKET_NAME = "realestateapibucket";
        public AwsStorage()
        {
            var config = new AmazonS3Config();
            config.RegionEndpoint = Amazon.RegionEndpoint.EUCentral1;
            client = new AmazonS3Client(ACCESS_KEY_ID, SECRET_ACCESS_KEY, config);

        }
        public async Task<bool> DeleteAsync(string directory, string fileName)
        {
            string s3key = String.Join('/', directory, fileName);

            var request = new DeleteObjectRequest()
            {
                BucketName = BUCKET_NAME,
                Key = s3key
            };

            var response = await client.DeleteObjectAsync(request);
            Console.WriteLine($"Successfully deleted {s3key} to {BUCKET_NAME}. Response: {response}");
            return true;
        }

        public Task<List<string>> GetFilesAsync(string directoryOrContainer)
        {
            throw new NotImplementedException();
        }

        public Task<FilePath> MoveFileAsync(string directoryOrContainer, string fileName, string moveDirectoryOrContainer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FilePath>> UploadAsync(string directoryOrContainer, IFormFileCollection formFiles)
        {
            List<FilePath> files = new List<FilePath>();
            foreach (var item in formFiles)
            {
                FilePath result = await UploadSingleAsync(directoryOrContainer, item);
                files.Add(result);
            }
            return files;
        }

        public async Task<FilePath> UploadSingleAsync(string directory, IFormFile formFile)
        {
            directory = directory.Replace("\\", "/");
            var fileContent = new byte[formFile.Length];
            formFile.OpenReadStream().Read(fileContent, 0, (int)formFile.Length);
            
            string fileNewName = await FileRenameAsync(directory, formFile.FileName, HasFile);
            string s3key = String.Join('/', directory, fileNewName);

            var request = new PutObjectRequest
            {
                BucketName = BUCKET_NAME,
                Key = s3key,
                InputStream = new MemoryStream(fileContent),
                CannedACL = S3CannedACL.PublicReadWrite,

            };

            var response = await client.PutObjectAsync(request);

            Console.WriteLine($"Successfully uploaded {s3key} to {BUCKET_NAME}. Response: {response}");
            return new FilePath(directory, formFile.FileName, "AWS");
        }

        public bool HasFile(string directory, string fileName)
        {
            directory = directory.Replace("\\", "/");

            var request = new ListObjectsV2Request()
            {
                BucketName = BUCKET_NAME,
                Prefix= String.Join("/",directory, fileName),
                
            };
            var response = client.ListObjectsV2Async(request).Result;

            if (response.S3Objects.Count > 0)
                return true;
            return false;
            
        }

    }
}
