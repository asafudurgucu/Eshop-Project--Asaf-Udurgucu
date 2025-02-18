using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eshop_Shared.ResponseDTOs
{
    public class ResponseDTO<T>
    {
        public T? Data { get; set; }
        public List<String>? Errors { get; set; }

        [JsonIgnore]
        public bool IsSucceded { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }



        public static ResponseDTO<T> Success(T data, int statusCode )
        {
            return new ResponseDTO<T> { Data = data, IsSucceded = true, StatusCode = statusCode };
        }

        public static ResponseDTO<T> Success(int statusCode)
        {
            return new ResponseDTO<T> { Data = default, IsSucceded = true, StatusCode = statusCode };
        }

        public static ResponseDTO<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDTO<T> { Errors = errors, IsSucceded = false, StatusCode = statusCode };
        }

        public static ResponseDTO<T> Fail(string error, int statusCode)
        {
            return new ResponseDTO<T> { Errors = new List<string> { error }, IsSucceded = false, StatusCode = statusCode };
        }

        
    }
}
