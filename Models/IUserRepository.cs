using System.Collections.Generic;

namespace UsersDashboard.Models
{
    public interface IUserRepository
    {
        void Create(User user);
        User Get(int id);
        List<User> GetUsers();
        void Update(User user);
        void Delete(int id);
    }
}