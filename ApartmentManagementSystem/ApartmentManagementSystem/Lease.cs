using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem
{
    public class Lease
    {
        public int LeaseId { get; set; }
        public int TenantId { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public bool IsRenewed { get; set; }
    }
    public static class Database
    {
        public static List<Lease> Leases = new List<Lease>();
    }


}
