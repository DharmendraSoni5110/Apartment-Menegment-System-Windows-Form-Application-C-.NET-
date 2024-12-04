using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagementSystem
{
    public partial class btnRentPayments : Form
    {
        private void btnTenantManagement_Click(object sender, EventArgs e)
        {
            TenantManagementForm tenantForm = new TenantManagementForm();
            tenantForm.ShowDialog();
        }

        private void btnRentPayments_Click(object sender, EventArgs e)
        {
            RentPaymentForm rentForm = new RentPaymentForm();
            rentForm.ShowDialog();
        }

        private void btnMaintenanceRequests_Click(object sender, EventArgs e)
        {
            MaintenanceRequestForm maintenanceForm = new MaintenanceRequestForm();
            maintenanceForm.ShowDialog();
        }

        private void btnLeaseManagement_Click(object sender, EventArgs e)
        {
            LeaseManagementForm leaseForm = new LeaseManagementForm();
            leaseForm.ShowDialog();
        }

    }
}
