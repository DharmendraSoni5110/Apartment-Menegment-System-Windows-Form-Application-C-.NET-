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
    public partial class RentPaymentForm : Form
    {
        public RentPaymentForm()
        {
            InitializeComponent();
        }
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            RentPaymentDatabase newPayment = new RentPaymentDatabase
            {
                PaymentId = Database.RentPayments.Count + 1,
                TenantId = Convert.ToInt32(cmbTenant.SelectedValue),  // assuming cmbTenant has tenant data
                Amount = Convert.ToDecimal(txtAmount.Text),
                PaymentDate = dtpPaymentDate.Value,
            };

            Database.RentPayments.Add(newPayment);
            UpdatePaymentGrid();
        }
        private void UpdatePaymentGrid()
        {
            dataGridViewPayments.DataSource = null;
            dataGridViewPayments.DataSource = Database.RentPayments;
        }


    }
}
