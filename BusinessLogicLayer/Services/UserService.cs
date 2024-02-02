using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Domain.Models;

namespace BusinessLogicLayer.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        List<User> IUserService.GetAllUsers()
        {
            return _userRepository.Select();
        }
    }
}
