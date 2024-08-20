using KancelAPI.Enum;
using KancelAPI.Models.Global;

namespace KancelAPI.Models.Financial
{
    public class SalaryCard : BaseModel
    {
        public Guid SalaryCardId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public ESalaryType SalaryType { get; set; }
        public DateTime SalaryDate { get; set; }
    }
}
