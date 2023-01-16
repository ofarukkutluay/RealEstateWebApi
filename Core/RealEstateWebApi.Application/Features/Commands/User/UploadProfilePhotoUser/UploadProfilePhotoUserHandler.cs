using MediatR;
using Microsoft.AspNetCore.Hosting;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.UploadProfilePhotoUser
{
    public class UploadProfilePhotoUserHandler : IRequestHandler<UploadProfilePhotoUserRequest, UploadProfilePhotoUserResponse>
    {
        private readonly IFileWriteRepository _fileWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IStorageService _storageService;

        public UploadProfilePhotoUserHandler(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, IFileWriteRepository fileWriteRepository, IStorageService storageService)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
            _fileWriteRepository = fileWriteRepository;
            _storageService = storageService;
        }

        public async Task<UploadProfilePhotoUserResponse> Handle(UploadProfilePhotoUserRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.UserId);
            if (user == null)
                return new UploadProfilePhotoUserResponse()
                {
                    Message = "Kullanıcı bulunamadı!",
                    Success = false
                };

            string directory = Path.Combine("upload-files","profile-photos");
            var storageResult = await _storageService.UploadSingleAsync(directory, request.ProfilePhoto);
            var fileResult = await _fileWriteRepository.AddAndSaveAsync(new Domain.Entities.File()
            {
                FileName = storageResult.FileName,
                Path = storageResult.DirectoryOrContainer,
                Storage = storageResult.Storage,
            });

            user.ProfileImgFileId = fileResult.Id;
            await _userWriteRepository.SaveAsync();

            return new UploadProfilePhotoUserResponse()
            {
                Success = true,
                Message = "Profile photo added"
            };


        }
    }
}
