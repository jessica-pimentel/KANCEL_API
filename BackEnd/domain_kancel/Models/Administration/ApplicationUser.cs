using domain_kancel.Enum;
using domain_kancel.Models.Financial;
using domain_Kancel.Models.Global;
using System;
using System.Collections.Generic;
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
        public string Password { get; set; }
        public EField Field { get; set; }

        //1FN
        List<IEnumerable<SalaryCard>> SalaryCards { get; set; }
        List<IEnumerable<PaymentCard>> PaymentCards { get; set; }
    }
}
