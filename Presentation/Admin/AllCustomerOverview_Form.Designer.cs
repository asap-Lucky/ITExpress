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
            this.bt_AddCustomer = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_ViewCustomer = new System.Windows.Forms.Button();
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_AllCustomersOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCustomersOverview)).BeginInit();
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
            this.bt_AddCustomer.Click += new System.EventHandler(this.bt_AddCustomer_Click);
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
            this.bt_ViewCustomer.Click += new System.EventHandler(this.bt_ViewCustomer_Click);
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
            this.dgv_AllCustomersOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllCustomersOverview.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllCustomersOverview.MultiSelect = false;
            this.dgv_AllCustomersOverview.Name = "dgv_AllCustomersOverview";
            this.dgv_AllCustomersOverview.ReadOnly = true;
            this.dgv_AllCustomersOverview.RowHeadersVisible = false;
            this.dgv_AllCustomersOverview.RowHeadersWidth = 40;
            this.dgv_AllCustomersOverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_AllCustomersOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllCustomersOverview.Size = new System.Drawing.Size(1056, 466);
            this.dgv_AllCustomersOverview.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllCustomersOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_AddCustomer;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_ViewCustomer;
        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridView dgv_AllCustomersOverview;
    }
}