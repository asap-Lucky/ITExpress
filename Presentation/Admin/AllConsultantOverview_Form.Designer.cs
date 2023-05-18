﻿namespace Presentation.Customer
{
    partial class AllConsultantOverview_Form
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
            this.bt_AddConsultant = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_ViewConsultant = new System.Windows.Forms.Button();
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.dgv_AllConsultantsOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllConsultantsOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddConsultant
            // 
            this.bt_AddConsultant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_AddConsultant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddConsultant.FlatAppearance.BorderSize = 0;
            this.bt_AddConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddConsultant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_AddConsultant.Location = new System.Drawing.Point(863, 503);
            this.bt_AddConsultant.Name = "bt_AddConsultant";
            this.bt_AddConsultant.Size = new System.Drawing.Size(205, 30);
            this.bt_AddConsultant.TabIndex = 10;
            this.bt_AddConsultant.Text = "Add new consultant";
            this.bt_AddConsultant.UseVisualStyleBackColor = false;
            this.bt_AddConsultant.Click += new System.EventHandler(this.bt_AddConsultant_Click);
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
            // bt_ViewConsultant
            // 
            this.bt_ViewConsultant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_ViewConsultant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_ViewConsultant.FlatAppearance.BorderSize = 0;
            this.bt_ViewConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewConsultant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ViewConsultant.Location = new System.Drawing.Point(427, 503);
            this.bt_ViewConsultant.Name = "bt_ViewConsultant";
            this.bt_ViewConsultant.Size = new System.Drawing.Size(205, 30);
            this.bt_ViewConsultant.TabIndex = 13;
            this.bt_ViewConsultant.Text = "View consultant";
            this.bt_ViewConsultant.UseVisualStyleBackColor = false;
            this.bt_ViewConsultant.Click += new System.EventHandler(this.bt_ViewConsultant_Click);
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
            // dgv_AllConsultantsOverview
            // 
            this.dgv_AllConsultantsOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllConsultantsOverview.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllConsultantsOverview.MultiSelect = false;
            this.dgv_AllConsultantsOverview.Name = "dgv_AllConsultantsOverview";
            this.dgv_AllConsultantsOverview.ReadOnly = true;
            this.dgv_AllConsultantsOverview.RowHeadersVisible = false;
            this.dgv_AllConsultantsOverview.RowHeadersWidth = 40;
            this.dgv_AllConsultantsOverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_AllConsultantsOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllConsultantsOverview.Size = new System.Drawing.Size(1056, 466);
            this.dgv_AllConsultantsOverview.TabIndex = 16;
            // 
            // AllConsultantOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_AllConsultantsOverview);
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_ViewConsultant);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_AddConsultant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllConsultantOverview_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllConsultantsOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_AddConsultant;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_ViewConsultant;
        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.DataGridView dgv_AllConsultantsOverview;
    }
}