using domain_Kancel.Enum;
using domain_Kancel.Models.Global;

namespace domain_Kancel.Models
{
    public class SalaryCard : BaseModel
    {
        public Guid SalaryCardId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public ESalaryType SalaryType { get; set; }
        public DateTime SalaryDate { get; set; }
    }
}
