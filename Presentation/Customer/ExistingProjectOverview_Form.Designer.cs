namespace Presentation.Customer
{
    partial class ExistingProjectOverview_Forn
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
            this.bt_OpenProject = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_EditProject = new System.Windows.Forms.Button();
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.bt_DeleteProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OpenProject
            // 
            this.bt_OpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_OpenProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_OpenProject.FlatAppearance.BorderSize = 0;
            this.bt_OpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OpenProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_OpenProject.Location = new System.Drawing.Point(1151, 619);
            this.bt_OpenProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_OpenProject.Name = "bt_OpenProject";
            this.bt_OpenProject.Size = new System.Drawing.Size(273, 37);
            this.bt_OpenProject.TabIndex = 10;
            this.bt_OpenProject.Text = "Open project";
            this.bt_OpenProject.UseVisualStyleBackColor = false;
            this.bt_OpenProject.Click += new System.EventHandler(this.bt_OpenProject_Click);
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
            this.bt_EditProject.Location = new System.Drawing.Point(853, 619);
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
            this.dgv_existingProjectsCustomer.AllowUserToAddRows = false;
            this.dgv_existingProjectsCustomer.AllowUserToDeleteRows = false;
            this.dgv_existingProjectsCustomer.AllowUserToResizeColumns = false;
            this.dgv_existingProjectsCustomer.AllowUserToResizeRows = false;
            this.dgv_existingProjectsCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_existingProjectsCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existingProjectsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existingProjectsCustomer.Location = new System.Drawing.Point(16, 15);
            this.dgv_existingProjectsCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_existingProjectsCustomer.Name = "dgv_existingProjectsCustomer";
            this.dgv_existingProjectsCustomer.RowHeadersVisible = false;
            this.dgv_existingProjectsCustomer.RowHeadersWidth = 51;
            this.dgv_existingProjectsCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_existingProjectsCustomer.Size = new System.Drawing.Size(1408, 574);
            this.dgv_existingProjectsCustomer.TabIndex = 14;
            this.dgv_existingProjectsCustomer.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_existingProjectsCustomer_CellValidating);
            this.dgv_existingProjectsCustomer.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged);
            // 
            // bt_DeleteProject
            // 
            this.bt_DeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_DeleteProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_DeleteProject.FlatAppearance.BorderSize = 0;
            this.bt_DeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_DeleteProject.Location = new System.Drawing.Point(559, 619);
            this.bt_DeleteProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DeleteProject.Name = "bt_DeleteProject";
            this.bt_DeleteProject.Size = new System.Drawing.Size(273, 37);
            this.bt_DeleteProject.TabIndex = 15;
            this.bt_DeleteProject.Text = "Delete project";
            this.bt_DeleteProject.UseVisualStyleBackColor = false;
            this.bt_DeleteProject.Click += new System.EventHandler(this.bt_DeleteProject_Click);
            // 
            // ExistingProjectOverview_Forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.bt_DeleteProject);
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_EditProject);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_OpenProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExistingProjectOverview_Forn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_OpenProject;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_EditProject;
        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.Button bt_DeleteProject;
    }
}