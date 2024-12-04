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
    public partial class MaintenanceRequestForm : Form
    {
        public MaintenanceRequestForm()
        {
            InitializeComponent();
        }
        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceDatabase newRequest = new MaintenanceDatabase
            {
                RequestId = Database.MaintenanceRequests.Count + 1,
                TenantId = Convert.ToInt32(cmbTenant.SelectedValue),
                IssueDescription = txtIssueDescription.Text,
                RequestDate = DateTime.Now,
                Status = cmbStatus.SelectedItem.ToString()
            };

            Database.MaintenanceRequests.Add(newRequest);
            UpdateMaintenanceGrid();
        }
        private void UpdateMaintenanceGrid()
        {
            dataGridViewMaintenance.DataSource = null;
            dataGridViewMaintenance.DataSource = Database.MaintenanceRequests;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
