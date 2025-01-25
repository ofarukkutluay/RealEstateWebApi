using MediatR;
using Microsoft.AspNetCore.Hosting;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.UploadBlogPageImgFile
{
    public class UploadBlogPageImgFileHandler : IRequestHandler<UploadBlogPageImgFileRequest, UploadBlogPageImgFileResponse>
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IStorageService _storageService;
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IFileWriteRepository _fileWriteRepository;

        public UploadBlogPageImgFileHandler(IFileWriteRepository fileWriteRepository, IBlogWriteRepository blogWriteRepository, IBlogReadRepository blogReadRepository, IStorageService storageService, IWebHostEnvironment webHostEnvironment)
        {
            _fileWriteRepository = fileWriteRepository;
            _blogWriteRepository = blogWriteRepository;
            _blogReadRepository = blogReadRepository;
            _storageService = storageService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<UploadBlogPageImgFileResponse> Handle(UploadBlogPageImgFileRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Blog blog = await _blogReadRepository.GetByIdAsync(request.BlogId);
            if(blog is null)
                return new UploadBlogPageImgFileResponse()
                {
                    Message = "Blog bulunamadı",
                    Success = false
                };
            
            string directory = Path.Combine(_webHostEnvironment.WebRootPath, "blog-images");
            FilePath filePath = await _storageService.UploadSingleAsync(directory, request.BlogPageImgFile);
            Domain.Entities.File file = new Domain.Entities.File
            {
                FileName = filePath.FileName,
                Path = filePath.DirectoryOrContainer,
                Storage = _storageService.StorageName
            };
            var addedFile = await _fileWriteRepository.AddAndSaveAsync(file);
            blog.BlogPageImgFileId = addedFile.Id;
            await _blogWriteRepository.SaveAsync();
            return new UploadBlogPageImgFileResponse()
            {
                Success=true
            };
        }
    }
}
