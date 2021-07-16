using System.Collections.Generic;

namespace UsersDashboard.Models
{
    public class UserRepository : IUserRepository
    {
        private string connectionString;

        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        public void Create(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}