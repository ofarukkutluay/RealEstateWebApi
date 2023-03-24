using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Abstractions.Storage;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize(Roles = "Admin")]
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IStorageService _storageService;
        public FileController(IWebHostEnvironment webHostEnvironment, IStorageService storageService)
        {
            _webHostEnvironment = webHostEnvironment;
            _storageService = storageService;
        }



        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            string directory = "example";
            var result = await _storageService.UploadSingleAsync(directory,formFile);
            return Ok(result);
        
        }

        [HttpPut]
        public async Task<IActionResult> MoveFile(string directory,string fileName)
        {
            var result = await _storageService.MoveFileAsync(directory,fileName,Path.Combine(_webHostEnvironment.WebRootPath,"upload-file"));
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string directory, string fileName)
        {
            var result = await _storageService.DeleteAsync(directory, fileName);
            return Ok(result);

        }
    }
}
