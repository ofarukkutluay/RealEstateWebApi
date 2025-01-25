namespace RealEstateWebApi.WebApp.Models.Common
{
    public class DataResult<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public int TotalDataCount { get; set; }
    }
}
