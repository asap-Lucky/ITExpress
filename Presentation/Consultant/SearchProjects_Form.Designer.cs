using System.Drawing;

namespace Presentation.Customer
{
    partial class SearchProjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_EndType = new System.Windows.Forms.ComboBox();
            this.cb_CodeLanguage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_ResetSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Projects = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_OpenProject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cb_EndType);
            this.panel1.Controls.Add(this.cb_CodeLanguage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_Search);
            this.panel1.Controls.Add(this.bt_ResetSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 601);
            this.panel1.TabIndex = 1;
            // 
            // cb_EndType
            // 
            this.cb_EndType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EndType.FormattingEnabled = true;
            this.cb_EndType.Location = new System.Drawing.Point(275, 315);
            this.cb_EndType.Name = "cb_EndType";
            this.cb_EndType.Size = new System.Drawing.Size(369, 24);
            this.cb_EndType.TabIndex = 36;
            // 
            // cb_CodeLanguage
            // 
            this.cb_CodeLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CodeLanguage.FormattingEnabled = true;
            this.cb_CodeLanguage.Location = new System.Drawing.Point(275, 109);
            this.cb_CodeLanguage.Name = "cb_CodeLanguage";
            this.cb_CodeLanguage.Size = new System.Drawing.Size(369, 24);
            this.cb_CodeLanguage.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label6.Location = new System.Drawing.Point(112, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "(Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(228, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
            // 
            // bt_Search
            // 
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bt_Search.Location = new System.Drawing.Point(521, 551);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(167, 30);
            this.bt_Search.TabIndex = 32;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_ResetSearch
            // 
            this.bt_ResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bt_ResetSearch.Location = new System.Drawing.Point(20, 551);
            this.bt_ResetSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ResetSearch.Name = "bt_ResetSearch";
            this.bt_ResetSearch.Size = new System.Drawing.Size(167, 30);
            this.bt_ResetSearch.TabIndex = 31;
            this.bt_ResetSearch.Text = "Reset search";
            this.bt_ResetSearch.UseVisualStyleBackColor = true;
            this.bt_ResetSearch.Click += new System.EventHandler(this.bt_ResetSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(15, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "End type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Project requierements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search projects:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Projects
            // 
            this.dgv_Projects.AllowUserToAddRows = false;
            this.dgv_Projects.AllowUserToDeleteRows = false;
            this.dgv_Projects.AllowUserToResizeColumns = false;
            this.dgv_Projects.AllowUserToResizeRows = false;
            this.dgv_Projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Projects.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Projects.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Projects.Location = new System.Drawing.Point(0, 90);
            this.dgv_Projects.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Projects.Name = "dgv_Projects";
            this.dgv_Projects.ReadOnly = true;
            this.dgv_Projects.RowHeadersVisible = false;
            this.dgv_Projects.RowHeadersWidth = 51;
            this.dgv_Projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Projects.Size = new System.Drawing.Size(656, 511);
            this.dgv_Projects.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgv_Projects);
            this.panel3.Location = new System.Drawing.Point(768, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 601);
            this.panel3.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(108, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matching projects:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_OpenProject
            // 
            this.bt_OpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_OpenProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_OpenProject.FlatAppearance.BorderSize = 0;
            this.bt_OpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OpenProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_OpenProject.Location = new System.Drawing.Point(1151, 634);
            this.bt_OpenProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_OpenProject.Name = "bt_OpenProject";
            this.bt_OpenProject.Size = new System.Drawing.Size(273, 37);
            this.bt_OpenProject.TabIndex = 33;
            this.bt_OpenProject.Text = "Send invitation";
            this.bt_OpenProject.UseVisualStyleBackColor = false;
            this.bt_OpenProject.Click += new System.EventHandler(this.bt_OpenProject_Click);
            // 
            // SearchProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.bt_OpenProject);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Projects;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_OpenProject;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_ResetSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_EndType;
        private System.Windows.Forms.ComboBox cb_CodeLanguage;
    }
}