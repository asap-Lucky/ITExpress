namespace Presentation.Customer
{
    partial class EditProjectConsultant_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_EndType = new System.Windows.Forms.ComboBox();
            this.cb_CodeLanguage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_projectHourWage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_projectName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_projectDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_TotalPay = new System.Windows.Forms.TextBox();
            this.tb_HoursSpent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cb_EndType);
            this.panel1.Controls.Add(this.cb_CodeLanguage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_endDate);
            this.panel1.Controls.Add(this.dtp_startDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_projectHourWage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_projectName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 590);
            this.panel1.TabIndex = 0;
            // 
            // cb_EndType
            // 
            this.cb_EndType.FormattingEnabled = true;
            this.cb_EndType.Location = new System.Drawing.Point(264, 290);
            this.cb_EndType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_EndType.Name = "cb_EndType";
            this.cb_EndType.Size = new System.Drawing.Size(371, 24);
            this.cb_EndType.TabIndex = 32;
            this.toolTip4.SetToolTip(this.cb_EndType, "Choose if the consultant has to have knowledge in regards of frontend, backend or" +
        " fullstack");
            // 
            // cb_CodeLanguage
            // 
            this.cb_CodeLanguage.FormattingEnabled = true;
            this.cb_CodeLanguage.Location = new System.Drawing.Point(264, 210);
            this.cb_CodeLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_CodeLanguage.Name = "cb_CodeLanguage";
            this.cb_CodeLanguage.Size = new System.Drawing.Size(371, 24);
            this.cb_CodeLanguage.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(16, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "End type:";
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Location = new System.Drawing.Point(264, 530);
            this.dtp_endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(371, 22);
            this.dtp_endDate.TabIndex = 28;
            this.toolTip3.SetToolTip(this.dtp_endDate, "End date of the project");
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(264, 464);
            this.dtp_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(371, 22);
            this.dtp_startDate.TabIndex = 27;
            this.toolTip2.SetToolTip(this.dtp_startDate, "Start date of the project");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "End date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Start date:";
            // 
            // tb_projectHourWage
            // 
            this.tb_projectHourWage.Location = new System.Drawing.Point(265, 363);
            this.tb_projectHourWage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_projectHourWage.Name = "tb_projectHourWage";
            this.tb_projectHourWage.Size = new System.Drawing.Size(369, 22);
            this.tb_projectHourWage.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hour wage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Code language required:";
            // 
            // tb_projectName
            // 
            this.tb_projectName.Location = new System.Drawing.Point(265, 129);
            this.tb_projectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.Size = new System.Drawing.Size(369, 22);
            this.tb_projectName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(15, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Project name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_projectDescription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(757, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 388);
            this.panel2.TabIndex = 1;
            // 
            // tb_projectDescription
            // 
            this.tb_projectDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_projectDescription.Location = new System.Drawing.Point(43, 78);
            this.tb_projectDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_projectDescription.Multiline = true;
            this.tb_projectDescription.Name = "tb_projectDescription";
            this.tb_projectDescription.Size = new System.Drawing.Size(587, 291);
            this.tb_projectDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SaveChanges.FlatAppearance.BorderSize = 0;
            this.bt_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SaveChanges.Location = new System.Drawing.Point(1145, 634);
            this.bt_SaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(273, 37);
            this.bt_SaveChanges.TabIndex = 27;
            this.bt_SaveChanges.Text = "Save changes";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            this.bt_SaveChanges.Click += new System.EventHandler(this.bt_SaveChanges_Click);
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_GoBack.FlatAppearance.BorderSize = 0;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_GoBack.Location = new System.Drawing.Point(17, 634);
            this.bt_GoBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(273, 37);
            this.bt_GoBack.TabIndex = 26;
            this.bt_GoBack.Text = "Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            this.bt_GoBack.Click += new System.EventHandler(this.bt_GoBack_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tb_TotalPay);
            this.panel3.Controls.Add(this.tb_HoursSpent);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(757, 422);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 183);
            this.panel3.TabIndex = 28;
            // 
            // tb_TotalPay
            // 
            this.tb_TotalPay.Location = new System.Drawing.Point(260, 126);
            this.tb_TotalPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TotalPay.Name = "tb_TotalPay";
            this.tb_TotalPay.Size = new System.Drawing.Size(369, 22);
            this.tb_TotalPay.TabIndex = 21;
            this.toolTip1.SetToolTip(this.tb_TotalPay, "This field displays the calculated pay that will be transfared to the consultant");
            // 
            // tb_HoursSpent
            // 
            this.tb_HoursSpent.Location = new System.Drawing.Point(260, 32);
            this.tb_HoursSpent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_HoursSpent.Name = "tb_HoursSpent";
            this.tb_HoursSpent.Size = new System.Drawing.Size(369, 22);
            this.tb_HoursSpent.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(21, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Accumulative pay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(21, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Consultant paid hours:";
            // 
            // EditProjectConsultant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditProjectConsultant_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_projectDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_projectName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_projectHourWage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_SaveChanges;
        private System.Windows.Forms.Button bt_GoBack;
        private System.Windows.Forms.ComboBox cb_EndType;
        private System.Windows.Forms.ComboBox cb_CodeLanguage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_TotalPay;
        private System.Windows.Forms.TextBox tb_HoursSpent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}