namespace Presentation.Customer
{
    partial class ConsultantClosedProjects
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
            this.dgv_closedProjects = new System.Windows.Forms.DataGridView();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_OpenProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_closedProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_closedProjects
            // 
            this.dgv_closedProjects.AllowUserToAddRows = false;
            this.dgv_closedProjects.AllowUserToDeleteRows = false;
            this.dgv_closedProjects.AllowUserToOrderColumns = true;
            this.dgv_closedProjects.AllowUserToResizeColumns = false;
            this.dgv_closedProjects.AllowUserToResizeRows = false;
            this.dgv_closedProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_closedProjects.BackgroundColor = System.Drawing.Color.White;
            this.dgv_closedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_closedProjects.Location = new System.Drawing.Point(23, 15);
            this.dgv_closedProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_closedProjects.MultiSelect = false;
            this.dgv_closedProjects.Name = "dgv_closedProjects";
            this.dgv_closedProjects.ReadOnly = true;
            this.dgv_closedProjects.RowHeadersVisible = false;
            this.dgv_closedProjects.RowHeadersWidth = 51;
            this.dgv_closedProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_closedProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_closedProjects.Size = new System.Drawing.Size(1401, 566);
            this.dgv_closedProjects.TabIndex = 18;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Refresh.Location = new System.Drawing.Point(16, 618);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(273, 37);
            this.bt_Refresh.TabIndex = 16;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            // 
            // bt_OpenProject
            // 
            this.bt_OpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_OpenProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_OpenProject.FlatAppearance.BorderSize = 0;
            this.bt_OpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OpenProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_OpenProject.Location = new System.Drawing.Point(1144, 618);
            this.bt_OpenProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_OpenProject.Name = "bt_OpenProject";
            this.bt_OpenProject.Size = new System.Drawing.Size(273, 37);
            this.bt_OpenProject.TabIndex = 15;
            this.bt_OpenProject.Text = "Open project";
            this.bt_OpenProject.UseVisualStyleBackColor = false;
            this.bt_OpenProject.Click += new System.EventHandler(this.bt_OpenProject_Click);
            // 
            // ConsultantClosedProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_closedProjects);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_OpenProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultantClosedProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_closedProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_closedProjects;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_OpenProject;
    }
}