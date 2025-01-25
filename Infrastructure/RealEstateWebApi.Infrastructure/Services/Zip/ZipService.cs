using System.IO.Compression;
using Microsoft.AspNetCore.Hosting;
using RealEstateWebApi.Application;

namespace RealEstateWebApi.Infrastructure.Services.Zip;

public class ZipService : IZipService
{

    private readonly IWebHostEnvironment _webHostEnvironment;

    public ZipService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public byte[] ZipFiles(string folderpath){
        string folderName = folderpath.Split(new char[] {'/','\\'}).Last();
        string fullfolderPath =Path.Combine(_webHostEnvironment.WebRootPath,folderpath);
        string tempFolderPath = Path.Combine(_webHostEnvironment.WebRootPath,"Temp","TempZipFolder",folderName);

        if(Directory.Exists(tempFolderPath)){
            Directory.Delete(tempFolderPath,true);
        }
        Directory.CreateDirectory(tempFolderPath);

        string[] files = Directory.GetFiles(fullfolderPath);

        foreach (string file in files)
        {
            string destPath = Path.Combine(tempFolderPath,Path.GetFileName(file));
            File.Copy(file, destPath, true);
        }

        string zipFilePath = Path.Combine(_webHostEnvironment.WebRootPath,"Temp",folderName+".zip");
        ZipFile.CreateFromDirectory(tempFolderPath,zipFilePath);

        byte[] zipBytes = File.ReadAllBytes(zipFilePath);

        Directory.Delete(tempFolderPath,true);
        File.Delete(zipFilePath);

        return zipBytes;

    }
}
