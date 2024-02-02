using InternetShop.Enums;

namespace InternetShop.Models
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } 
        public StatusType Status { get; set; }
        public BaseResponse()
        {
            Status = StatusType.OK;
            Message = string.Empty;
        }
    }
}
