namespace ApartmentManagementSystem
{
    partial class btnRentPayments
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTenantManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMaintenanceRequests = new System.Windows.Forms.Button();
            this.btnLeaseManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btnTenantManagement
            // 
            this.btnTenantManagement.Location = new System.Drawing.Point(85, 327);
            this.btnTenantManagement.Name = "btnTenantManagement";
            this.btnTenantManagement.Size = new System.Drawing.Size(130, 77);
            this.btnTenantManagement.TabIndex = 1;
            this.btnTenantManagement.Text = "Tenant Management";
            this.btnTenantManagement.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rent Payments";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMaintenanceRequests
            // 
            this.btnMaintenanceRequests.Location = new System.Drawing.Point(613, 327);
            this.btnMaintenanceRequests.Name = "btnMaintenanceRequests";
            this.btnMaintenanceRequests.Size = new System.Drawing.Size(146, 77);
            this.btnMaintenanceRequests.TabIndex = 3;
            this.btnMaintenanceRequests.Text = "Maintenance Requests";
            this.btnMaintenanceRequests.UseVisualStyleBackColor = true;
            // 
            // btnLeaseManagement
            // 
            this.btnLeaseManagement.Location = new System.Drawing.Point(871, 327);
            this.btnLeaseManagement.Name = "btnLeaseManagement";
            this.btnLeaseManagement.Size = new System.Drawing.Size(138, 77);
            this.btnLeaseManagement.TabIndex = 4;
            this.btnLeaseManagement.Text = "Lease Management";
            this.btnLeaseManagement.UseVisualStyleBackColor = true;
            // 
            // btnRentPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 504);
            this.Controls.Add(this.btnLeaseManagement);
            this.Controls.Add(this.btnMaintenanceRequests);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTenantManagement);
            this.Controls.Add(this.label1);
            this.Name = "btnRentPayments";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTenantManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMaintenanceRequests;
        private System.Windows.Forms.Button btnLeaseManagement;

    }
}

