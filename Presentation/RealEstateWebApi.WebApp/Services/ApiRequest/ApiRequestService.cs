using Newtonsoft.Json;


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

        public async Task<TResult> Get<TResult>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(apiUrl + path);

                return JsonConvert.DeserializeObject<TResult>(response);

            }
        }

        public async Task<TResult> Get<TResult>(string path, params string[] keys )
        {
            using (HttpClient client = new HttpClient())
            {
                var url = apiUrl + path;
                foreach (var key in keys)
                {
                    url += key;
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

                var response = await client.PostAsync(apiUrl + path, jsonContent);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }

        }

        public async Task<TResult> Put<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonContent = JsonContent.Create(content);

                var response = await client.PutAsync(apiUrl + path, jsonContent);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }

        }

        public async Task<TResult> Delete<TResult>(string path, object content)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonContent = JsonContent.Create(content);
                var response = await client.DeleteAsync(apiUrl + path);

                return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
