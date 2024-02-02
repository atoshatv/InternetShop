using BusinessLogicLayer.Interfaces;
using Domain.Models;
using InternetShop.Enums;

using InternetShop.Models;

namespace InternetShop.Services
{
    public class BaseUserService
    {
        IUserService _userService;
        public BaseUserService(IUserService userService)
        {
            _userService = userService;
        }

        public BaseResponse<List<User>> GetAllUsers() 
        { 
            var response = new BaseResponse<List<User>>();
            try
            {
                response.Data = _userService.GetAllUsers();
            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
                response.Status = StatusType.Error;
            }


            return response;
        }
    }
}
