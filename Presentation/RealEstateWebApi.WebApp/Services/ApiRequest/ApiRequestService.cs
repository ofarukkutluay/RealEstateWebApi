using Newtonsoft.Json;
using RealEstateWebApi.WebApp.Models.Common;
using System.Net.Http.Headers;


namespace RealEstateWebApi.WebApp.Services.ApiRequest
{
    public class ApiRequestService
    {
 
        private readonly HttpClient httpClient;
        public ApiRequestService(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        public async Task<ApiResult<object>> GetApiStatus()
        {

            var response = await httpClient.GetStringAsync("/");

            return JsonConvert.DeserializeObject<ApiResult<object>>(response);

        }

        public async Task<TResult> Get<TResult>(string path)
        {

            var response = await httpClient.GetFromJsonAsync<TResult>(path);

            return response;
        }

        public async Task<TResult> Get<TResult>(string path, params string[] keys)
        {


            foreach (var key in keys)
            {
                path += key;
            }

            var response = await httpClient.GetFromJsonAsync<TResult>(path);

            return response;


        }

        public async Task<TResult> Post<TResult>(string path, object content)
        {

            var jsonContent = JsonContent.Create(content);


            var response = await httpClient.PostAsync(path, jsonContent);

            return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());


        }

        public async Task<TResult> PostForm<TResult>(string path, object content)
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

                var response = await httpClient.PostAsync(path, multipartContent);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }


        }

        public async Task<TResult> Put<TResult>(string path, object content)
        {

            var jsonContent = JsonContent.Create(content);


            var response = await httpClient.PutAsync(path, jsonContent);

            return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());


        }

        public async Task<TResult> Delete<TResult>(string path, object content)
        {

            var jsonContent = JsonContent.Create(content);

            var result = httpClient.SendAsync(
                new HttpRequestMessage(HttpMethod.Delete, path)
                {
                    Content = jsonContent
                })
                .Result;

            return JsonConvert.DeserializeObject<TResult>(await result.Content.ReadAsStringAsync());
        }
    }
}

