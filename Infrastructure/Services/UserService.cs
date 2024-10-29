using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repo)
        {
            _repository = repo;
        }

        public int AddUser(User user)
        {
            return _repository.Insert(user);
        }

        public int DeleteUser(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<User> GetAllUser()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateUser(User user, int id)
        {
            if (user.Id == id)
            {
                return _repository.Update(user);
            }
            return 0;
        }
    }
}
