using System;
using System.Windows.Forms;

namespace ApartmentManagementSystem
{
    public partial class btnRentPayments : Form
    {
        // Constructor for btnRentPayments form
        public btnRentPayments()
        {
            InitializeComponent();
        }

        // Event handler for Tenant Management button
        private void btnTenantManagement_Click(object sender, EventArgs e)
        {
            TenantManagementForm tenantForm = new TenantManagementForm();
            tenantForm.ShowDialog();
            tenantForm.BringToFront(); // Ensures the form is brought to the front
        }




        // Event handler for Rent Payments button
        private void btnRentPayments_Click(object sender, EventArgs e)
        {
            RentPaymentForm rentForm = new RentPaymentForm();
            rentForm.ShowDialog(); // Show the rent payments form
        }

        // Event handler for Maintenance Requests button
        private void btnMaintenanceRequests_Click(object sender, EventArgs e)
        {
            MaintenanceRequestForm maintenanceForm = new MaintenanceRequestForm();
            maintenanceForm.ShowDialog(); // Show the maintenance requests form
        }

        // Event handler for Lease Management button
        private void btnLeaseManagement_Click(object sender, EventArgs e)
        {
            LeaseManagementForm leaseForm = new LeaseManagementForm();
            leaseForm.ShowDialog(); // Show the lease management form
        }
    }
}
