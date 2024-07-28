using domain_kancel.Interfaces.Repository.Administration;
using domain_kancel.Models.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra_kancel.Repository.Administration
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        public Task<bool> Add(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePassword(string newPassword, string lastPassword)
        {
            throw new NotImplementedException();
        }
    }
}
