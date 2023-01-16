using HtmlAgilityPack;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Domain.Entities;
using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace RealEstateWebApi.Infrastructure.Services.Scraping
{
    public class ShScrapingService : IShScrapingService
    {
        private readonly IStorageService _storageService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ShScrapingService(IStorageService storageService, IWebHostEnvironment webHostEnvironment)
        {
            _storageService = storageService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<PropertyListingDetail> GetListingDetail(string url, string document, string directoryPath)
        {
            PropertyListingDetail listingDetail = new();
            listingDetail.Shlink = url;

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(document);

            HtmlNode titleArea = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='classifiedDetailTitle']");
            string title = HtmlEntity.DeEntitize(titleArea.Element("h1").InnerText).Trim();
            listingDetail.Title = title;
            Console.WriteLine($"{title} ilanınız getiriliyor... ");

            HtmlNode contentArea = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='classifiedDetailContent']");

            HtmlNode infoBox = contentArea.SelectSingleNode("//div[@class='classifiedInfo ']");

            string[] price = infoBox.Element("h3").FirstChild.InnerText.Trim().Replace(".", "").Split(" ");
            listingDetail.Price = double.Parse(price[0]);
            listingDetail.Currency = price[1];

            HtmlNode[] adress = infoBox.Element("h2").Elements("a").ToArray();
            string city = adress[0].InnerText.Trim();
            string district = adress[1].InnerText.Trim();
            string neighborhood = adress[2].InnerText.Trim();

            listingDetail.City = city;
            listingDetail.District = district;
            listingDetail.Neighborhood = neighborhood;

            IEnumerable<HtmlNode> details = infoBox.Element("ul").Elements("li");
            foreach (var item in details)
            {
                string name = HtmlEntity.DeEntitize(item.Element("strong").InnerText).Trim().Replace("&nbsp;", "");
                string value = HtmlEntity.DeEntitize(item.Element("span").InnerText).Trim().Replace("&nbsp;", "");

                listingDetail.Id = name == "İlan No" ? uint.Parse(value) : listingDetail.Id;
                listingDetail.ListingDate = name == "İlan Tarihi" ? DateTime.Parse(value) : listingDetail.ListingDate;

                if (name == "Emlak Tipi")
                {
                    string[] statustype = value.Split(" ");
                    listingDetail.Status = statustype[0];
                    listingDetail.Type = statustype[1];
                }

                listingDetail.Category = name == "Kategori" ? value : listingDetail.Category;
                listingDetail.Status = name == "Durumu" && String.IsNullOrEmpty(listingDetail.Status) ? value : listingDetail.Status;
                listingDetail.Type = name == "Türü" || name == "Emlak Türü" ? value : listingDetail.Type;
                listingDetail.ReconstructionStatus = name == "İmar Durumu" ? value : listingDetail.ReconstructionStatus;
                listingDetail.StructureType = name == "Yapı Tipi" ? value : listingDetail.StructureType;

                listingDetail.GrossSquareMeter = name == "m² (Brüt)" || name == "m²" ? int.Parse(value.Replace(".", "")) : listingDetail.GrossSquareMeter;
                listingDetail.UsableSquareMeter = name == "m² (Net)" ? int.Parse(value) : listingDetail.UsableSquareMeter;
                listingDetail.PricePerSquareMeter = name == "m² Fiyatı" ? double.Parse(value.Replace(".", "")) : listingDetail.PricePerSquareMeter;
                listingDetail.IndoorAreaSquareMeter = name == "Kapalı Alan (m2)" ? int.Parse(value.Replace(".", "")) : listingDetail.IndoorAreaSquareMeter;
                listingDetail.OutdoorAreaSquareMeter = name == "Açık Alan (m2)" ? int.Parse(value.Replace(".", "")) : listingDetail.OutdoorAreaSquareMeter;


                listingDetail.BlockNo = name == "Ada No" ? value : listingDetail.BlockNo;
                listingDetail.PlotNo = name == "Parsel No" ? value : listingDetail.PlotNo;
                listingDetail.LayoutNo = name == "Pafta No" ? value : listingDetail.LayoutNo;
                listingDetail.FloorAreaRatio = name == "Kaks (Emsal)" ? value.Replace(".", ",") : listingDetail.FloorAreaRatio;
                listingDetail.Gabari = name == "Gabari" ? value.Replace(".", ",") : listingDetail.Gabari;

                if (name.Contains("Oda Sayısı"))
                {
                    string[] roomCount = value.Split("+");
                    string[] rc = roomCount[0].Trim().Replace("Stüdyo", "").Replace("(", "").Replace(")", "").Replace(".", ",").Split(" ");
                    if (roomCount.Count() > 0)
                        listingDetail.RoomCount = double.Parse(rc[0]);
                    if (rc.Length > 1)
                        listingDetail.LivingRoomCount = short.Parse(rc[0]);
                    if (roomCount.Count() > 1)
                        listingDetail.LivingRoomCount = short.Parse(roomCount[1].Trim().Replace("(", "").Replace(")", ""));
                }

                listingDetail.BuildingAge = name == "Bina Yaşı" || name == "Binanın Yaşı" ? value : listingDetail.BuildingAge;
                listingDetail.Floor = name == "Bulunduğu Kat" ? value : listingDetail.Floor;
                listingDetail.BuildingTotalFloor = name == "Kat Sayısı" ? value : listingDetail.BuildingTotalFloor;
                listingDetail.ElevatorCount = name == "Asansör Sayısı" ? value : listingDetail.ElevatorCount;
                listingDetail.InletHeight = name == "Giriş Yüksekliği (m)" ? value.Replace(".", ",") : listingDetail.InletHeight;

                listingDetail.HeatingType = name == "Isıtma" ? value : listingDetail.HeatingType;
                listingDetail.BathroomCount = name == "Banyo Sayısı" ? short.Parse(value) : listingDetail.BathroomCount;
                listingDetail.IsThereBalcony = name == "Balkon" ? (value == "Var" ? true : false) : listingDetail.IsThereBalcony;
                listingDetail.IsFurnished = name == "Eşyalı" ? (value == "Evet" ? true : false) : listingDetail.IsFurnished;
                listingDetail.UsingStatus = name == "Kullanım Durumu" || name == "Kiracılı" ? (value == "Evet" ? "Kiracılı" : value) : listingDetail.UsingStatus;
                listingDetail.IsOnSite = name == "Site İçerisinde" ? (value == "Evet" ? true : false) : listingDetail.IsOnSite;
                listingDetail.SiteName = name == "Site Adı" ? value : listingDetail.SiteName;
                listingDetail.Fees = name == "Aidat (TL)" ? (value != "Belirtilmemiş" ? double.Parse(value) : 0) : listingDetail.Fees;
                listingDetail.IsAvailableLoan = name == "Krediye Uygun" || name == "Krediye Uygunluk" ? (value == "Evet" ? true : false) : listingDetail.IsAvailableLoan;
                listingDetail.DeedStatus = name == "Tapu Durumu" ? value : listingDetail.DeedStatus;
                listingDetail.FromProfile = name == "Kimden" ? value : listingDetail.FromProfile;
                listingDetail.IsBarter = name == "Takas" ? (value == "Evet" ? true : false) : listingDetail.IsBarter;
                listingDetail.AlcoholLicense = name == "Alkol Ruhsatı" ? (value == "Var" ? true : false) : listingDetail.AlcoholLicense;
                listingDetail.SoilSurvey = name == "Zemin Etüdü" ? (value == "Var" ? true : false) : listingDetail.SoilSurvey;


            }

            var sellerBox = contentArea.SelectSingleNode("//div[@class='classifiedOtherBoxes ']");
            try
            {
                //var projectCard = sellerBox.FindElement(By.ClassName("project-classified-user-box"));
                //string projectName = projectCard.FindElement(By.ClassName("project-name")).Text;
                //string projectFinishDate = projectCard.FindElement(By.ClassName("project-date")).Text;
                //string projectSeller = projectCard.FindElement(By.ClassName("store-name")).Text;
                //string projectSellerPhone = projectCard.FindElement(By.CssSelector("span.phone-value")).Text;
                //listingDetail.ListingStoreName = projectName;
                //listingDetail.ListingUserName = projectSeller;
                //listingDetail.ListingPhoneNumbers = projectSellerPhone;
            }
            catch (System.Exception ex)
            {

                Console.WriteLine("Proje firması değil. " + ex.Message);
            }

            try
            {
                var storeCard = sellerBox.SelectSingleNode("//*[@id=\"classifiedDetail\"]/div/div[2]/div[3]/div[1]");
                string storeName = storeCard.SelectSingleNode("//div[@class='user-info-store-name']").InnerText.Trim();
                string storeAgent = storeCard.SelectSingleNode("//*[@id=\"classifiedDetail\"]/div/div[2]/div[3]/div[1]/div[4]/h3").InnerText.Trim();
                var storeAgentPhones = storeCard.SelectSingleNode("//*[@id=\"classifiedDetail\"]/div/div[2]/div[3]/div[1]/div[5]").Element("dl").Elements("div");
                string phones = "";
                foreach (var item in storeAgentPhones)
                {

                    phones += item.Element("dd").InnerText.Replace("(", "").Replace(")", "").Replace(" ", "") + " ";
                }
                listingDetail.ListingStoreName = storeName;
                listingDetail.ListingUserName = storeAgent;
                listingDetail.ListingPhoneNumbers = phones;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Emlak ofisi değil. " + ex.Message);

            }

            try
            {
                HtmlNode userCard = sellerBox.SelectSingleNode("//div[@class='classifiedUserContent ']");
                string storeName = userCard.SelectSingleNode("//span[@class='store-card']").InnerText.Trim();
                string sellerName = userCard.SelectSingleNode("//div[@class='username-info-area']").Element("h5").InnerText.Trim();
                var sellerMobile = userCard.Element("ul").Elements("li");
                string phones = "";
                foreach (var item in sellerMobile)
                {

                    phones += item.Element("span").InnerText.Trim().Replace("(", "").Replace(")", "").Replace(" ", "") + " ";
                }
                listingDetail.ListingStoreName = storeName;
                listingDetail.ListingUserName = sellerName;
                listingDetail.ListingPhoneNumbers = phones;
            }
            catch (System.Exception ex)
            {

                Console.WriteLine("İnşaat ofisi değil. " + ex.Message);
            }

            try
            {
                HtmlNode userCard = sellerBox.SelectSingleNode("//div[@class='classifiedUserContent ']");
                string username = userCard.FirstChild.NextSibling.Element("h5").InnerText.Trim();
                IEnumerable<HtmlNode> phoneNodes = userCard.Element("ul").Elements("li");
                string phones = "";
                foreach (var item in phoneNodes)
                {

                    phones += item.Element("span").InnerText.Trim().Replace("(", "").Replace(")", "").Replace(" ", "") + " ";
                }
                listingDetail.ListingUserName = username;
                listingDetail.ListingPhoneNumbers = phones;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Sahibinden değil. " + ex.Message);
            }


            HtmlNode descriptionArea = htmlDoc.GetElementbyId("classifiedDescription");
            listingDetail.Description = HtmlEntity.DeEntitize(descriptionArea.InnerText).Trim();
            listingDetail.DescriptionHtml = HtmlEntity.DeEntitize(descriptionArea.OuterHtml).Trim();

            HtmlNode mapArea = htmlDoc.GetElementbyId("gmap");
            listingDetail.LocationLat = double.Parse(mapArea.Attributes["data-lat"].Value.Replace(".", ","));
            listingDetail.LocationLon = double.Parse(mapArea.Attributes["data-lon"].Value.Replace(".", ","));

            HtmlNode megaPhotoImg = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"megaPhotoBox\"]/div[2]/div[1]/div/div/div").Element("img");
            string megaPhotoImgSrc = megaPhotoImg.Attributes["lazy-src"].Value;

            HtmlNodeCollection thmbImgs = htmlDoc.DocumentNode.SelectNodes("//img[@class='thmbImg']");
            if (thmbImgs == null)
            {
                thmbImgs = htmlDoc.DocumentNode.SelectNodes("//img[@class='stdImg']");
            }
            List<string> photolinks = new List<string>();
            List<string> photoPaths = new List<string>();
            listingDetail.PropertyListingPhotos = new List<PropertyListingPhoto>();

            string datePath = Path.Combine(directoryPath, listingDetail.ListingDate?.ToString("dd-MM-yyyy"), listingDetail.Id.ToString());

            using (var httpClient = new HttpClient())
            {
                string megaPhotoImgLinkTemp = megaPhotoImgSrc.Split("_")[0];
                int thmbImgCount = thmbImgs.Count;
                foreach (var item in thmbImgs)
                {
                    string thmbImgIndex;
                    try
                    {
                        thmbImgIndex = item.ParentNode.Attributes["data-megaindex"].Value;
                    }
                    catch (Exception)
                    {
                        thmbImgCount += 1;
                        thmbImgIndex = thmbImgCount.ToString();
                    }

                    string thmbImgSrcExtension = item.Attributes["src"].Value.Split("_")[1];
                    string megaLink = megaPhotoImgLinkTemp + "_" + thmbImgSrcExtension;

                    int i = 0;
                    while (i < 3)
                    {

                        try
                        {
                            Uri uri = new Uri(megaLink);
                            string fileNameAndExtension = uri.Segments.Last();

                            if (_storageService.HasFile(Path.Combine(_webHostEnvironment.WebRootPath, datePath), $"{thmbImgIndex}_{fileNameAndExtension}"))
                            {
                                photoPaths.Add(Path.Combine(datePath, $"{thmbImgIndex}_{fileNameAndExtension}"));
                                photolinks.Add(megaLink);
                                break;
                            }
                            var imageBytes = await httpClient.GetByteArrayAsync(uri);

                            using (Stream stream = new MemoryStream(imageBytes))
                            {
                                IFormFile formFile = new FormFile(stream, 0, imageBytes.Length, Path.GetFileNameWithoutExtension(fileNameAndExtension), $"{thmbImgIndex}_{fileNameAndExtension}");

                                var fileResult = await _storageService.UploadSingleAsync(datePath, formFile);
                                listingDetail.PropertyListingPhotos.Add(new PropertyListingPhoto
                                {
                                    FileName = fileResult.FileName,
                                    Path = fileResult.DirectoryOrContainer,
                                    Storage = fileResult.Storage,
                                    SortIndex = int.Parse(thmbImgIndex),
                                    PropertyListingDetailId = listingDetail.Id
                                });
                                photoPaths.Add(fileResult.FullPath);
                            }
                            photolinks.Add(megaLink);

                            break;
                        }
                        catch (Exception ex)
                        {
                            i++;
                            Console.WriteLine(megaLink + " - " + ex.Message);
                            string code = megaLink.Split("_")[0].Split("/").Last();

                            if (i == 2)
                                megaLink = megaLink.Replace(code, "x5");
                            else if (code == "big")
                                megaLink = megaLink.Replace(code, "x16");
                            else if (code == "x16")
                                megaLink = megaLink.Replace(code, "big");

                        }
                    }

                }
            }

            listingDetail.ShPhotoLinks = JsonSerializer.Serialize(photolinks.ToArray());
            listingDetail.PhotoPaths = JsonSerializer.Serialize(photoPaths.ToArray());
            listingDetail.CreatedDate = DateTime.UtcNow;


            var options = new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
            string jsonResult = JsonSerializer.Serialize(listingDetail, options);

            byte[] jsonByteArray = Encoding.UTF8.GetBytes(jsonResult);
            using (Stream stream1 = new MemoryStream(jsonByteArray))
            {
                IFormFile formFile = new FormFile(stream1, 0, jsonByteArray.Length, "detail", "detail.json");
                var fileResult = await _storageService.UploadSingleAsync(datePath, formFile);
            }

            return listingDetail;
        }
    }
}
