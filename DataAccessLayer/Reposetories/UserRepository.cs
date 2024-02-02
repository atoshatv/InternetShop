using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using Domain.Models;

namespace DataAccessLayer.Reposetories
{
    public class UserRepository : IUserRepository
    {
        public User Create(User model)
        {
            using (var database = new EntityDataBase()) {
                var entry = database.Users.Add(model);
                return entry.Entity;
            }
        }

        public bool Delete(User model)
        {
            using (var database = new EntityDataBase())
            {
                var entity = database.Users.First(u => u.Id == model.Id);
                var entry = database.Users.Remove(entity);
                return true;
            }
        }

        public User Read(Guid id)
        {
            using (var database = new EntityDataBase())
            {
                return database.Users.First(u => u.Id == id);
            }
        }

        public List<User> Select()
        {
            using (var database = new EntityDataBase())
            {
                return database.Users.ToList();
            }
        }

        public User Update(User model)
        {
            using (var database = new EntityDataBase())
            {
                var entry = database.Users.Update(model);
                return entry.Entity;
            }
        }
    }
}
