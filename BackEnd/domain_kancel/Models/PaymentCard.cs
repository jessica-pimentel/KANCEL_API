using domain_Kancel.Enum;
using domain_Kancel.Models.Global;

namespace domain_Kancel.Models
{
    public class PaymentCard : BaseModel
    {
        public Guid PaymentCardId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public EPaymentType PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
