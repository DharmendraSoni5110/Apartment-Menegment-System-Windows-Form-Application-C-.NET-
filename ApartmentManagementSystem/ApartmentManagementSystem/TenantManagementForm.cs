using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApartmentManagementSystem
{
    public partial class TenantManagementForm : Form
    {
        // Create a new instance of Database to access Tenants
        private Database database;

        public TenantManagementForm()
        {
            InitializeComponent();
            // Initialize the database object
            database = new Database();
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            // Create a new tenant object from the form data
            TenantDatabase newTenant = new TenantDatabase
            {
                TenantId = database.Tenants.Count + 1,  // Simple ID generation based on the current count
                Name = txtName.Text,
                ApartmentNumber = txtApartmentNumber.Text,
                ContactInfo = txtContactInfo.Text,
                LeaseStartDate = dtpLeaseStartDate.Value,
                LeaseEndDate = dtpLeaseEndDate.Value
            };

            // Add the new tenant to the database
            database.Tenants.Add(newTenant);

            // Update the tenant grid view
            UpdateTenantGrid();
        }

        private void UpdateTenantGrid()
        {
            // Set the data source of the DataGridView to the updated Tenants list
            dataGridViewTenants.DataSource = null;
            dataGridViewTenants.DataSource = database.Tenants;
        }
    }
}
