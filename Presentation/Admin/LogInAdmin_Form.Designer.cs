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
            this.bt_LogInAsAdmin = new System.Windows.Forms.Button();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.tb_passWordAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userNameAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.bt_LogInAsAdmin);
            this.panel1.Controls.Add(this.bt_GoBack);
            this.panel1.Controls.Add(this.tb_passWordAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_userNameAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Location = new System.Drawing.Point(80, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 440);
            this.panel1.TabIndex = 7;
            // 
            // bt_LogInAsAdmin
            // 
            this.bt_LogInAsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_LogInAsAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_LogInAsAdmin.FlatAppearance.BorderSize = 0;
            this.bt_LogInAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogInAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LogInAsAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogInAsAdmin.Location = new System.Drawing.Point(283, 353);
            this.bt_LogInAsAdmin.Name = "bt_LogInAsAdmin";
            this.bt_LogInAsAdmin.Size = new System.Drawing.Size(104, 30);
            this.bt_LogInAsAdmin.TabIndex = 7;
            this.bt_LogInAsAdmin.Text = "Log in";
            this.bt_LogInAsAdmin.UseVisualStyleBackColor = false;
            this.bt_LogInAsAdmin.Click += new System.EventHandler(this.bt_LogInAsAdmin_Click);
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
            // tb_passWordAdmin
            // 
            this.tb_passWordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_passWordAdmin.Location = new System.Drawing.Point(106, 241);
            this.tb_passWordAdmin.Name = "tb_passWordAdmin";
            this.tb_passWordAdmin.PasswordChar = '*';
            this.tb_passWordAdmin.Size = new System.Drawing.Size(229, 21);
            this.tb_passWordAdmin.TabIndex = 4;
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
            // tb_userNameAdmin
            // 
            this.tb_userNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_userNameAdmin.Location = new System.Drawing.Point(106, 153);
            this.tb_userNameAdmin.Name = "tb_userNameAdmin";
            this.tb_userNameAdmin.Size = new System.Drawing.Size(229, 21);
            this.tb_userNameAdmin.TabIndex = 2;
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
        private System.Windows.Forms.TextBox tb_passWordAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userNameAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_LogInAsAdmin;
        private System.Windows.Forms.Button bt_GoBack;
    }
}