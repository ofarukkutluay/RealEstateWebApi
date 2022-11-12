using Newtonsoft.Json;
using RealEstateWebApi.WebApp.Models.Common;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace RealEstateWebApi.WebApp.Services.ApiRequest
{
    public class ApiRequestService
    {
        private readonly IConfiguration Configuration;
        public ApiRequestService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private string apiUrl { get => Configuration["ApiUrl"]; }
        public string Token { get; set; }


        public async Task<ApiResult<object>> GetApiStatus()
        {
            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var response = await client.GetStringAsync(apiUrl);

                return JsonConvert.DeserializeObject<ApiResult<object>>(response);

            }
        }

        public async Task<TResult> Get<TResult>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var response = await client.GetStringAsync(apiUrl + path);

                return JsonConvert.DeserializeObject<TResult>(response);

            }
        }

        public async Task<TResult> Get<TResult>(string path, params string[] keys)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = apiUrl + path;
                foreach (var key in keys)
                {
                    url += key;
                }

                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var response = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<TResult>(response);

            }
        }

        public async Task<TResult> Post<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonContent = JsonContent.Create(content);

                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var response = await client.PostAsync(apiUrl + path, jsonContent);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }

        }

        public async Task<TResult> PostForm<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {

                using (var multipartContent = new MultipartFormDataContent())
                {

                    foreach (var prop in content.GetType().GetProperties())
                    {
                        var value = prop.GetValue(content);
                        if (value is IFormFile)
                        {
                            var file = value as IFormFile;
                            multipartContent.Add(new StreamContent(file.OpenReadStream()), prop.Name, file.FileName);
                            multipartContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = prop.Name, FileName = file.FileName };
                        }
                        else
                        {
                            multipartContent.Add(new StringContent(JsonConvert.SerializeObject(value)), prop.Name);
                        }
                    }


                    if (!string.IsNullOrEmpty(Token))
                    {
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                    }

                    var response = await client.PostAsync(apiUrl + path, multipartContent);

                    return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
                }
            }

        }

        public async Task<TResult> Put<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonContent = JsonContent.Create(content);

                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var response = await client.PutAsync(apiUrl + path, jsonContent);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }

        }

        public async Task<TResult> Delete<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonContent = JsonContent.Create(content);

                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
                }

                var result = client.SendAsync(
                    new HttpRequestMessage(HttpMethod.Delete, apiUrl + path)
                    {
                        Content = jsonContent
                    })
                    .Result;

                return JsonConvert.DeserializeObject<TResult>(await result.Content.ReadAsStringAsync());
            }
        }
    }
}
