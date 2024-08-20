using KancelAPI.Enum;
using KancelAPI.Models.Authentication;
using KancelAPI.Models.Financial;
using KancelAPI.Models.Global;
using System.ComponentModel.DataAnnotations.Schema;

namespace KancelAPI.Models.Administration
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
