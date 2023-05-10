namespace Presentation.Costumer
{
    partial class ExistingProject_Form
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
            this.bt_OpenProject.Location = new System.Drawing.Point(22, 75);
            this.bt_OpenProject.Name = "bt_OpenProject";
            this.bt_OpenProject.Size = new System.Drawing.Size(205, 30);
            this.bt_OpenProject.TabIndex = 10;
            this.bt_OpenProject.Text = "Open project";
            this.bt_OpenProject.UseVisualStyleBackColor = false;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Refresh.Location = new System.Drawing.Point(22, 391);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(205, 30);
            this.bt_Refresh.TabIndex = 12;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            // 
            // bt_EditProject
            // 
            this.bt_EditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_EditProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_EditProject.FlatAppearance.BorderSize = 0;
            this.bt_EditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_EditProject.Location = new System.Drawing.Point(22, 235);
            this.bt_EditProject.Name = "bt_EditProject";
            this.bt_EditProject.Size = new System.Drawing.Size(205, 30);
            this.bt_EditProject.TabIndex = 13;
            this.bt_EditProject.Text = "Edit project";
            this.bt_EditProject.UseVisualStyleBackColor = false;
            // 
            // dgv_existingProjectsCustomer
            // 
            this.dgv_existingProjectsCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existingProjectsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existingProjectsCustomer.Location = new System.Drawing.Point(258, 12);
            this.dgv_existingProjectsCustomer.Name = "dgv_existingProjectsCustomer";
            this.dgv_existingProjectsCustomer.Size = new System.Drawing.Size(810, 533);
            this.dgv_existingProjectsCustomer.TabIndex = 14;
            // 
            // ExistingProject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_EditProject);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_OpenProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExistingProject_Form";
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
    }
}