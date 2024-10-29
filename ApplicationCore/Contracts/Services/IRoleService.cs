using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IRoleService
    {
        int AddRole(Role role);
        int UpdateRole(Role role, int id);
        int DeleteRole(int id);
        IEnumerable<Role> GetAllRole();
        Role GetRoleById(int id);
    }
}
