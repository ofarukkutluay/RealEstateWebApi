﻿namespace RealEstateWebApi.WebApp.Models.Common
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string InternalMessage { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
