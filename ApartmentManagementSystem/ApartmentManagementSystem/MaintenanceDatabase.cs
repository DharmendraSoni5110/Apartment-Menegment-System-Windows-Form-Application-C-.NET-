using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem
{
    public class MaintenanceDatabase
    {
        public int RequestId { get; set; }
        public int TenantId { get; set; }
        public string IssueDescription { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
    }
    public partial class Database
    {
        public static List<MaintenanceDatabase> MaintenanceRequests = new List<MaintenanceDatabase>();
    }

}
