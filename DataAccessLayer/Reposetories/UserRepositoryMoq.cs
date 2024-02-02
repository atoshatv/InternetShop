using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using Domain.Models;

namespace DataAccessLayer.Reposetories
{
    public class UserRepositoryMoq : IUserRepository
    {
        public User Create(User model)
        {
            DataBaseMoq.Users.Add(model);
            return model;
        }

        public bool Delete(User model)
        {
            DataBaseMoq.Users.RemoveAll(u => u.Id == model.Id);
            return true;
        }

        public User Read(Guid id)
        {
            return DataBaseMoq.Users.First(u => u.Id == id);
        }

        public List<User> Select()
        {
            return DataBaseMoq.Users;
        }

        public User Update(User model)
        {
            var index = DataBaseMoq.Users.IndexOf(model);
            DataBaseMoq.Users[index] = model;
            return DataBaseMoq.Users[index];
        }
    }
}
