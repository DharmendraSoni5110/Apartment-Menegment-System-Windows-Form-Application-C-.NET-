using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem
{
    public class RentPaymentDatabase
    {
        public int PaymentId { get; set; }
        public int TenantId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
    }
    public partial class Database
    {
        public static List<RentPaymentDatabase> RentPayments = new List<RentPaymentDatabase>();
    }


}
