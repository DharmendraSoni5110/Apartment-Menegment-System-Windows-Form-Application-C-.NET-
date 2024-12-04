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
    public partial class TenantManagementForm : Form
    {
        public TenantManagementForm()
        {
            InitializeComponent();
        }
        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            TenantDatabase newTenant = new TenantDatabase
            {
                TenantId = Database.Tenants.Count + 1,  // Simple ID generation
                Name = txtName.Text,
                ApartmentNumber = txtApartmentNumber.Text,
                ContactInfo = txtContactInfo.Text,
                LeaseStartDate = dtpLeaseStartDate.Value,
                LeaseEndDate = dtpLeaseEndDate.Value
            };

            Database.Tenants.Add(newTenant);
            UpdateTenantGrid();
        }
        private void UpdateTenantGrid()
        {
            dataGridViewTenants.DataSource = null;
            dataGridViewTenants.DataSource = Database.Tenants;
        }

    }
}
