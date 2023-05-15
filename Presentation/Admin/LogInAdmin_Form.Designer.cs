namespace UI.All
{
    partial class LogInAdmin_Form
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
            this.bt_LogInAsCostumer = new System.Windows.Forms.Button();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.tb_passWordCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userNameCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.bt_LogInAsCostumer);
            this.panel1.Controls.Add(this.bt_GoBack);
            this.panel1.Controls.Add(this.tb_passWordCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_userNameCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Location = new System.Drawing.Point(80, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 440);
            this.panel1.TabIndex = 7;
            // 
            // bt_LogInAsCostumer
            // 
            this.bt_LogInAsCostumer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_LogInAsCostumer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_LogInAsCostumer.FlatAppearance.BorderSize = 0;
            this.bt_LogInAsCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogInAsCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LogInAsCostumer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogInAsCostumer.Location = new System.Drawing.Point(283, 353);
            this.bt_LogInAsCostumer.Name = "bt_LogInAsCostumer";
            this.bt_LogInAsCostumer.Size = new System.Drawing.Size(104, 30);
            this.bt_LogInAsCostumer.TabIndex = 7;
            this.bt_LogInAsCostumer.Text = "Log in";
            this.bt_LogInAsCostumer.UseVisualStyleBackColor = false;
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_GoBack.FlatAppearance.BorderSize = 0;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_GoBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_GoBack.Location = new System.Drawing.Point(40, 353);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(104, 30);
            this.bt_GoBack.TabIndex = 6;
            this.bt_GoBack.Text = "Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            // 
            // tb_passWordCustomer
            // 
            this.tb_passWordCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_passWordCustomer.Location = new System.Drawing.Point(106, 241);
            this.tb_passWordCustomer.Name = "tb_passWordCustomer";
            this.tb_passWordCustomer.PasswordChar = '*';
            this.tb_passWordCustomer.Size = new System.Drawing.Size(229, 21);
            this.tb_passWordCustomer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // tb_userNameCustomer
            // 
            this.tb_userNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_userNameCustomer.Location = new System.Drawing.Point(106, 153);
            this.tb_userNameCustomer.Name = "tb_userNameCustomer";
            this.tb_userNameCustomer.Size = new System.Drawing.Size(229, 21);
            this.tb_userNameCustomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // lb_LogInSign
            // 
            this.lb_LogInSign.AutoSize = true;
            this.lb_LogInSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.lb_LogInSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lb_LogInSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LogInSign.Location = new System.Drawing.Point(87, 35);
            this.lb_LogInSign.Name = "lb_LogInSign";
            this.lb_LogInSign.Size = new System.Drawing.Size(265, 54);
            this.lb_LogInSign.TabIndex = 0;
            this.lb_LogInSign.Text = "Admin login";
            this.lb_LogInSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInAdmin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(584, 560);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 599);
            this.MinimumSize = new System.Drawing.Size(600, 599);
            this.Name = "LogInAdmin_Form";
            this.Text = "Log in";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_LogInSign;
        private System.Windows.Forms.TextBox tb_passWordCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userNameCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_LogInAsCostumer;
        private System.Windows.Forms.Button bt_GoBack;
    }
}