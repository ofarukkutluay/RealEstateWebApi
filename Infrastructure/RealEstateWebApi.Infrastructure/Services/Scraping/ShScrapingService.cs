﻿
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Domain.Entities;
using ListingWebsiteScrapingLibrary;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace RealEstateWebApi.Infrastructure.Services.Scraping
{
    public class ShScrapingService : IShScrapingService
    {
        private readonly IStorageService _storageService;
        private readonly ShScraping _shScraping;
        private readonly IMapper _mapper;

        public ShScrapingService(IStorageService storageService, ShScraping shScraping, IMapper mapper)
        {
            _storageService = storageService;
            _shScraping = shScraping;
            _mapper = mapper;
        }

        public async Task<Domain.Entities.OuterPropertyListing> GetListingDetail(string url, string document, string directoryPath)
        {
            var result = await _shScraping.GetListingDetail(document);

            Domain.Entities.OuterPropertyListing listingDetail = _mapper.Map<Domain.Entities.OuterPropertyListing>(result);

            List<PropertyListingPhoto> photoPaths = new List<PropertyListingPhoto>();

            int thmbImgIndex = 0;
            foreach (string megaLink in result.PhotoLinks)
            {

                Uri uri = new Uri(megaLink);
                string fileNameAndExtension = uri.Segments.Last();

                string fullDirectory = Path.Combine(directoryPath, result.Id);

                string finalFileName = $"{fileNameAndExtension}";

                if (!_storageService.HasFile(Path.Combine(Environment.CurrentDirectory, "wwwroot", fullDirectory), finalFileName))
                {
                    if (Directory.Exists(Path.Combine(Environment.CurrentDirectory, "wwwroot", fullDirectory)))
                    {
                        thmbImgIndex = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "wwwroot", fullDirectory)).Count() - 1;
                    }
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var imageBytes = await httpClient.GetByteArrayAsync(uri);

                        using (Stream stream = new MemoryStream(imageBytes))
                        {
                            IFormFile formFile = new FormFile(stream, 0, imageBytes.Length, Path.GetFileNameWithoutExtension(fileNameAndExtension), finalFileName);

                            var fileResult = await _storageService.UploadSingleAsync(fullDirectory, formFile);
                            photoPaths.Add(new PropertyListingPhoto
                            {
                                Path = fileResult.DirectoryOrContainer,
                                FileName = fileResult.FileName,
                                SortIndex = thmbImgIndex,
                                OuterPropertyListingId = listingDetail.Id,
                                Storage = _storageService.StorageName
                            });
                        }

                    }
                }


                thmbImgIndex += 1;

            }

            listingDetail.PropertyListingPhotos = photoPaths;
            listingDetail.PhotoPaths = JsonSerializer.Serialize(photoPaths);
            listingDetail.PhotoLinks = JsonSerializer.Serialize(result.PhotoLinks);
            listingDetail.Features = JsonSerializer.Serialize(result.Features);

            return listingDetail;

        }
    }
}
