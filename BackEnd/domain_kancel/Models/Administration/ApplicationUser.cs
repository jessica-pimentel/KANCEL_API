using domain_kancel.Enum;
using domain_kancel.Models.Authentication;
using domain_kancel.Models.Financial;
using domain_Kancel.Models.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain_kancel.Models.Administration
{
    public class ApplicationUser : BaseModel
    {
        public Guid ApplicationUserId { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string _passwordHash { get; set; }
        public EField Field { get; set; }

        [NotMapped]
        public string Password
        {
            get => _passwordHash;
            set => _passwordHash = PasswordHasher.HashPassword(value);
        }

        //1FN
        List<IEnumerable<SalaryCard>> SalaryCards { get; set; }
        List<IEnumerable<PaymentCard>> PaymentCards { get; set; }


    }
}
