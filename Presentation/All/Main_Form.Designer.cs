namespace UI
{
    partial class Main_Form
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
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.bt_LogInAsCostumer = new System.Windows.Forms.Button();
            this.bt_LogInAsConsultant = new System.Windows.Forms.Button();
            this.bt_LogInAsAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_LogInSign
            // 
            this.lb_LogInSign.AutoSize = true;
            this.lb_LogInSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.lb_LogInSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lb_LogInSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LogInSign.Location = new System.Drawing.Point(44, 22);
            this.lb_LogInSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LogInSign.Name = "lb_LogInSign";
            this.lb_LogInSign.Size = new System.Drawing.Size(464, 85);
            this.lb_LogInSign.TabIndex = 0;
            this.lb_LogInSign.Text = "Choose user";
            this.lb_LogInSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_LogInAsCostumer
            // 
            this.bt_LogInAsCostumer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_LogInAsCostumer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_LogInAsCostumer.FlatAppearance.BorderSize = 0;
            this.bt_LogInAsCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogInAsCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bt_LogInAsCostumer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogInAsCostumer.Location = new System.Drawing.Point(267, 246);
            this.bt_LogInAsCostumer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_LogInAsCostumer.Name = "bt_LogInAsCostumer";
            this.bt_LogInAsCostumer.Size = new System.Drawing.Size(267, 62);
            this.bt_LogInAsCostumer.TabIndex = 1;
            this.bt_LogInAsCostumer.Text = "Costumer";
            this.bt_LogInAsCostumer.UseVisualStyleBackColor = false;
            this.bt_LogInAsCostumer.Click += new System.EventHandler(this.bt_LogInAsCostumer_Click);
            // 
            // bt_LogInAsConsultant
            // 
            this.bt_LogInAsConsultant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_LogInAsConsultant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_LogInAsConsultant.FlatAppearance.BorderSize = 0;
            this.bt_LogInAsConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogInAsConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bt_LogInAsConsultant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogInAsConsultant.Location = new System.Drawing.Point(267, 374);
            this.bt_LogInAsConsultant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_LogInAsConsultant.Name = "bt_LogInAsConsultant";
            this.bt_LogInAsConsultant.Size = new System.Drawing.Size(267, 62);
            this.bt_LogInAsConsultant.TabIndex = 2;
            this.bt_LogInAsConsultant.Text = "Consultant";
            this.bt_LogInAsConsultant.UseVisualStyleBackColor = false;
            this.bt_LogInAsConsultant.Click += new System.EventHandler(this.bt_LogInAsConsultant_Click);
            // 
            // bt_LogInAsAdmin
            // 
            this.bt_LogInAsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_LogInAsAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_LogInAsAdmin.FlatAppearance.BorderSize = 0;
            this.bt_LogInAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogInAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LogInAsAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogInAsAdmin.Location = new System.Drawing.Point(16, 639);
            this.bt_LogInAsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_LogInAsAdmin.Name = "bt_LogInAsAdmin";
            this.bt_LogInAsAdmin.Size = new System.Drawing.Size(139, 37);
            this.bt_LogInAsAdmin.TabIndex = 3;
            this.bt_LogInAsAdmin.Text = "Admin";
            this.bt_LogInAsAdmin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Location = new System.Drawing.Point(117, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 542);
            this.panel1.TabIndex = 4;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(776, 681);
            this.Controls.Add(this.bt_LogInAsConsultant);
            this.Controls.Add(this.bt_LogInAsCostumer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_LogInAsAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(794, 728);
            this.MinimumSize = new System.Drawing.Size(794, 728);
            this.Name = "Main_Form";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_LogInSign;
        private System.Windows.Forms.Button bt_LogInAsCostumer;
        private System.Windows.Forms.Button bt_LogInAsConsultant;
        private System.Windows.Forms.Button bt_LogInAsAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}

