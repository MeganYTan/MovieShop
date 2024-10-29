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
    public class RoleService : IRoleService
    {
        private IRoleRepository _repository;
        public RoleService(IRoleRepository repo)
        {
            _repository = repo;
        }

        public int AddRole(Role role)
        {
            return _repository.Insert(role);
        }

        public int DeleteRole(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Role> GetAllRole()
        {
            return _repository.GetAll();
        }

        public Role GetRoleById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateRole(Role role, int id)
        {
            if (role.Id == id)
            {
                return _repository.Update(role);
            }
            return 0;
        }
    }
}
