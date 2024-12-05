using System;
using System.Collections.Generic;

namespace ApartmentManagementSystem
{
    // Make the TenantDatabase class public
    public class TenantDatabase
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string ApartmentNumber { get; set; }
        public string ContactInfo { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
    }

    public partial class Database
    {
        // Public field for storing tenants
        public List<TenantDatabase> Tenants = new List<TenantDatabase>();
    }
}
