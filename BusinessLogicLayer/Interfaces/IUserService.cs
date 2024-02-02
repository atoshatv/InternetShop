using Domain.Models;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
    }
}
