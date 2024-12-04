using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem
{
    class TenantDatabase
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string ApartmentNumber { get; set; }
        public string ContactInfo { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
    }
    public static class Database
    {
        public static List<TenantDatabase> Tenants = new List<TenantDatabase>();
    }

}
