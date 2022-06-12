using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Abstractions.Storage;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<IActionResult> Upload(IFormFileCollection formFiles)
        {
            string directory = Path.Combine(Environment.CurrentDirectory,"upload-files");
            var result = await _storageService.UploadAsync(directory,formFiles);
            return Ok(result);
        
        }

        [HttpPut]
        public async Task<IActionResult> MoveFile(string directory,string fileName)
        {
            var result = await _storageService.MoveFileAsync(directory,fileName,Path.Combine(_webHostEnvironment.WebRootPath,"upload-file"));
            return Ok(result);
        }
    }
}
