namespace ApartmentManagementSystem
{
    partial class LeaseManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTenant = new System.Windows.Forms.ComboBox();
            this.dtpLeaseStartDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewLeases = new System.Windows.Forms.DataGridView();
            this.dtpLeaseEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeases)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTenant
            // 
            this.cmbTenant.FormattingEnabled = true;
            this.cmbTenant.Location = new System.Drawing.Point(617, 86);
            this.cmbTenant.Name = "cmbTenant";
            this.cmbTenant.Size = new System.Drawing.Size(214, 24);
            this.cmbTenant.TabIndex = 0;
            // 
            // dtpLeaseStartDate
            // 
            this.dtpLeaseStartDate.Location = new System.Drawing.Point(617, 175);
            this.dtpLeaseStartDate.Name = "dtpLeaseStartDate";
            this.dtpLeaseStartDate.Size = new System.Drawing.Size(214, 22);
            this.dtpLeaseStartDate.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeases
            // 
            this.dataGridViewLeases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeases.Location = new System.Drawing.Point(145, 389);
            this.dataGridViewLeases.Name = "dataGridViewLeases";
            this.dataGridViewLeases.RowTemplate.Height = 24;
            this.dataGridViewLeases.Size = new System.Drawing.Size(605, 95);
            this.dataGridViewLeases.TabIndex = 3;
            // 
            // dtpLeaseEndDate
            // 
            this.dtpLeaseEndDate.Location = new System.Drawing.Point(617, 250);
            this.dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            this.dtpLeaseEndDate.Size = new System.Drawing.Size(214, 22);
            this.dtpLeaseEndDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tenant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ending Date";
            // 
            // LeaseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLeaseEndDate);
            this.Controls.Add(this.dataGridViewLeases);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpLeaseStartDate);
            this.Controls.Add(this.cmbTenant);
            this.Name = "LeaseManagementForm";
            this.Text = "LeaseManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTenant;
        private System.Windows.Forms.DateTimePicker dtpLeaseStartDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewLeases;
        private System.Windows.Forms.DateTimePicker dtpLeaseEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}