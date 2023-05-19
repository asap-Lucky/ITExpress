using System.Drawing;

namespace Presentation.Customer
{
    partial class SearchConsultant
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_OpenProject = new System.Windows.Forms.Button();
            this.bt_SearchMatchingConsultant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(0, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(492, 415);
            this.dataGridView2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 488);
            this.panel2.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 415);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current projects:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(576, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 488);
            this.panel3.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(81, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matching consultants:";
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
            this.bt_OpenProject.Location = new System.Drawing.Point(863, 515);
            this.bt_OpenProject.Name = "bt_OpenProject";
            this.bt_OpenProject.Size = new System.Drawing.Size(205, 30);
            this.bt_OpenProject.TabIndex = 33;
            this.bt_OpenProject.Text = "Send invitation";
            this.bt_OpenProject.UseVisualStyleBackColor = false;
            this.bt_OpenProject.Click += new System.EventHandler(this.bt_OpenProject_Click);
            // 
            // bt_SearchMatchingConsultant
            // 
            this.bt_SearchMatchingConsultant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SearchMatchingConsultant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SearchMatchingConsultant.FlatAppearance.BorderSize = 0;
            this.bt_SearchMatchingConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SearchMatchingConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchMatchingConsultant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SearchMatchingConsultant.Location = new System.Drawing.Point(12, 515);
            this.bt_SearchMatchingConsultant.Name = "bt_SearchMatchingConsultant";
            this.bt_SearchMatchingConsultant.Size = new System.Drawing.Size(242, 30);
            this.bt_SearchMatchingConsultant.TabIndex = 34;
            this.bt_SearchMatchingConsultant.Text = "Search matching consultant";
            this.bt_SearchMatchingConsultant.UseVisualStyleBackColor = false;
            this.bt_SearchMatchingConsultant.Click += new System.EventHandler(this.bt_SearchMatchingConsultant_Click);
            // 
            // SearchConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1084, 557);
            this.ControlBox = false;
            this.Controls.Add(this.bt_SearchMatchingConsultant);
            this.Controls.Add(this.bt_OpenProject);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchConsultant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_OpenProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_SearchMatchingConsultant;
    }
}