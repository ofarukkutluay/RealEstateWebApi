using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Scraping
{
    public interface IShScrapingService
    {
        public Task<OuterPropertyListing> GetListingDetail(string url, string document, string directoryPath);
    }
}
