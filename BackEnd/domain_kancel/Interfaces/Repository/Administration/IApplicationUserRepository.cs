using domain_kancel.Models.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain_kancel.Interfaces.Repository.Administration
{
    public interface IApplicationUserRepository
    {
        Task<bool> Login(string email, string password);
        Task<bool> Add(ApplicationUser applicationUser);
        Task<bool> UpdatePassword(string newPassword, string lastPassword);
    }
}
