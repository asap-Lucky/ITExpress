namespace Presentation.Customer
{
    partial class AllProjectsOverview_Form
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
            this.bt_ViewProject = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_EditProject = new System.Windows.Forms.Button();
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_AllProjectsOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProjectsOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ViewProject
            // 
            this.bt_ViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_ViewProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_ViewProject.FlatAppearance.BorderSize = 0;
            this.bt_ViewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ViewProject.Location = new System.Drawing.Point(1151, 619);
            this.bt_ViewProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ViewProject.Name = "bt_ViewProject";
            this.bt_ViewProject.Size = new System.Drawing.Size(273, 37);
            this.bt_ViewProject.TabIndex = 10;
            this.bt_ViewProject.Text = "View project";
            this.bt_ViewProject.UseVisualStyleBackColor = false;
            this.bt_ViewProject.Click += new System.EventHandler(this.bt_ViewProject_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Refresh.Location = new System.Drawing.Point(16, 619);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(273, 37);
            this.bt_Refresh.TabIndex = 12;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_EditProject
            // 
            this.bt_EditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_EditProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_EditProject.FlatAppearance.BorderSize = 0;
            this.bt_EditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_EditProject.Location = new System.Drawing.Point(840, 619);
            this.bt_EditProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditProject.Name = "bt_EditProject";
            this.bt_EditProject.Size = new System.Drawing.Size(273, 37);
            this.bt_EditProject.TabIndex = 13;
            this.bt_EditProject.Text = "Edit project";
            this.bt_EditProject.UseVisualStyleBackColor = false;
            this.bt_EditProject.Click += new System.EventHandler(this.bt_EditProject_Click);
            // 
            // dgv_existingProjectsCustomer
            // 
            this.dgv_existingProjectsCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existingProjectsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existingProjectsCustomer.Location = new System.Drawing.Point(16, 15);
            this.dgv_existingProjectsCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_existingProjectsCustomer.Name = "dgv_existingProjectsCustomer";
            this.dgv_existingProjectsCustomer.RowHeadersWidth = 51;
            this.dgv_existingProjectsCustomer.Size = new System.Drawing.Size(1408, 574);
            this.dgv_existingProjectsCustomer.TabIndex = 14;
            // 
            // dgv_AllProjectsOverview
            // 
            this.dgv_AllProjectsOverview.AllowUserToAddRows = false;
            this.dgv_AllProjectsOverview.AllowUserToDeleteRows = false;
            this.dgv_AllProjectsOverview.AllowUserToResizeColumns = false;
            this.dgv_AllProjectsOverview.AllowUserToResizeRows = false;
            this.dgv_AllProjectsOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllProjectsOverview.Location = new System.Drawing.Point(16, 15);
            this.dgv_AllProjectsOverview.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_AllProjectsOverview.MultiSelect = false;
            this.dgv_AllProjectsOverview.Name = "dgv_AllProjectsOverview";
            this.dgv_AllProjectsOverview.RowHeadersVisible = false;
            this.dgv_AllProjectsOverview.RowHeadersWidth = 40;
            this.dgv_AllProjectsOverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_AllProjectsOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllProjectsOverview.Size = new System.Drawing.Size(1408, 574);
            this.dgv_AllProjectsOverview.TabIndex = 16;
            this.dgv_AllProjectsOverview.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_AllProjectsOverview_CellValidating);
            this.dgv_AllProjectsOverview.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_AllProjectsOverview_CurrentCellDirtyStateChanged);
            // 
            // AllProjectsOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_AllProjectsOverview);
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_EditProject);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_ViewProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllProjectsOverview_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProjectsOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_ViewProject;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_EditProject;
        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridView dgv_AllProjectsOverview;
    }
}