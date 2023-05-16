namespace Presentation.Customer
{
    partial class AllCustomerOverview_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_AddCustomer = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_ViewCustomer = new System.Windows.Forms.Button();
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.dgv_AllCustomersOverview = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCustomersOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddCustomer
            // 
            this.bt_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_AddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddCustomer.FlatAppearance.BorderSize = 0;
            this.bt_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_AddCustomer.Location = new System.Drawing.Point(863, 503);
            this.bt_AddCustomer.Name = "bt_AddCustomer";
            this.bt_AddCustomer.Size = new System.Drawing.Size(205, 30);
            this.bt_AddCustomer.TabIndex = 10;
            this.bt_AddCustomer.Text = "Add new customer";
            this.bt_AddCustomer.UseVisualStyleBackColor = false;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Refresh.Location = new System.Drawing.Point(12, 503);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(205, 30);
            this.bt_Refresh.TabIndex = 12;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            // 
            // bt_ViewCustomer
            // 
            this.bt_ViewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_ViewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_ViewCustomer.FlatAppearance.BorderSize = 0;
            this.bt_ViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ViewCustomer.Location = new System.Drawing.Point(427, 503);
            this.bt_ViewCustomer.Name = "bt_ViewCustomer";
            this.bt_ViewCustomer.Size = new System.Drawing.Size(205, 30);
            this.bt_ViewCustomer.TabIndex = 13;
            this.bt_ViewCustomer.Text = "View customer";
            this.bt_ViewCustomer.UseVisualStyleBackColor = false;
            // 
            // dgv_existingProjectsCustomer
            // 
            this.dgv_existingProjectsCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existingProjectsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existingProjectsCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgv_existingProjectsCustomer.Name = "dgv_existingProjectsCustomer";
            this.dgv_existingProjectsCustomer.Size = new System.Drawing.Size(1056, 466);
            this.dgv_existingProjectsCustomer.TabIndex = 14;
            // 
            // dgv_AllCustomersOverview
            // 
            this.dgv_AllCustomersOverview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.dgv_AllCustomersOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AllCustomersOverview.AutoGenerateColumns = false;
            this.dgv_AllCustomersOverview.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AllCustomersOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllCustomersOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerLoginDataGridViewTextBoxColumn,
            this.customerPasswordDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerZipCodeDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPhoneNumberDataGridViewTextBoxColumn});
            this.dgv_AllCustomersOverview.DataSource = this.customerBindingSource;
            this.dgv_AllCustomersOverview.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllCustomersOverview.MultiSelect = false;
            this.dgv_AllCustomersOverview.Name = "dgv_AllCustomersOverview";
            this.dgv_AllCustomersOverview.ReadOnly = true;
            this.dgv_AllCustomersOverview.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_AllCustomersOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllCustomersOverview.Size = new System.Drawing.Size(1056, 465);
            this.dgv_AllCustomersOverview.TabIndex = 15;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DAL.Database.Customer);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.FillWeight = 75F;
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_FirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "Customer_FirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_LastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Customer_LastName";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLoginDataGridViewTextBoxColumn
            // 
            this.customerLoginDataGridViewTextBoxColumn.DataPropertyName = "Customer_Login";
            this.customerLoginDataGridViewTextBoxColumn.HeaderText = "Customer_Login";
            this.customerLoginDataGridViewTextBoxColumn.Name = "customerLoginDataGridViewTextBoxColumn";
            this.customerLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPasswordDataGridViewTextBoxColumn
            // 
            this.customerPasswordDataGridViewTextBoxColumn.DataPropertyName = "Customer_Password";
            this.customerPasswordDataGridViewTextBoxColumn.HeaderText = "Customer_Password";
            this.customerPasswordDataGridViewTextBoxColumn.Name = "customerPasswordDataGridViewTextBoxColumn";
            this.customerPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerZipCodeDataGridViewTextBoxColumn
            // 
            this.customerZipCodeDataGridViewTextBoxColumn.DataPropertyName = "Customer_ZipCode";
            this.customerZipCodeDataGridViewTextBoxColumn.HeaderText = "Customer_ZipCode";
            this.customerZipCodeDataGridViewTextBoxColumn.Name = "customerZipCodeDataGridViewTextBoxColumn";
            this.customerZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "Customer_City";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "Customer_City";
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            this.customerCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Customer_PhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Customer_PhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllCustomerOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_AllCustomersOverview);
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_ViewCustomer);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_AddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCustomerOverview_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCustomersOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_AddCustomer;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_ViewCustomer;
        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.DataGridView dgv_AllCustomersOverview;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
    }
}