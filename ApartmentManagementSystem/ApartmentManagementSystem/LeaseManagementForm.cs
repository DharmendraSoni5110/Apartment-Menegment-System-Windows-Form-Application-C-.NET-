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
    public partial class LeaseManagementForm : Form
    {
        public LeaseManagementForm()
        {
            InitializeComponent();
        }
        private void btnRenewLease_Click(object sender, EventArgs e)
        {
            Lease newLease = new Lease
            {
                LeaseId = Database.Leases.Count + 1,
                TenantId = Convert.ToInt32(cmbTenant.SelectedValue),
                LeaseStartDate = dtpLeaseStartDate.Value,
                LeaseEndDate = dtpLeaseEndDate.Value,
                IsRenewed = true
            };

            Database.Leases.Add(newLease);
            UpdateLeaseGrid();
        }
        private void UpdateLeaseGrid()
        {
            dataGridViewLeases.DataSource = null;
            dataGridViewLeases.DataSource = Database.Leases;
        }

    }
}
