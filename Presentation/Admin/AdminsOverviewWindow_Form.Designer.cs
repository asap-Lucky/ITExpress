namespace Presentation.Consultant
{
    partial class AdminsOverviewWindow_Form
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bt_LogOut = new System.Windows.Forms.Button();
            this.bt_SpecializationList = new System.Windows.Forms.Button();
            this.bt_ConsultantList = new System.Windows.Forms.Button();
            this.bt_CustomerList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_firstNameOfAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.bt_LogOut);
            this.panelMenu.Controls.Add(this.bt_SpecializationList);
            this.panelMenu.Controls.Add(this.bt_ConsultantList);
            this.panelMenu.Controls.Add(this.bt_CustomerList);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.bt_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_LogOut.FlatAppearance.BorderSize = 0;
            this.bt_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LogOut.Location = new System.Drawing.Point(0, 601);
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.Size = new System.Drawing.Size(200, 60);
            this.bt_LogOut.TabIndex = 7;
            this.bt_LogOut.Text = "Log out";
            this.bt_LogOut.UseVisualStyleBackColor = false;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            // 
            // bt_SpecializationList
            // 
            this.bt_SpecializationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_SpecializationList.FlatAppearance.BorderSize = 0;
            this.bt_SpecializationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SpecializationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_SpecializationList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_SpecializationList.Location = new System.Drawing.Point(0, 220);
            this.bt_SpecializationList.Name = "bt_SpecializationList";
            this.bt_SpecializationList.Size = new System.Drawing.Size(200, 60);
            this.bt_SpecializationList.TabIndex = 3;
            this.bt_SpecializationList.Text = "Specialization list";
            this.bt_SpecializationList.UseVisualStyleBackColor = true;
            this.bt_SpecializationList.Click += new System.EventHandler(this.bt_SpecializationList_Click);
            // 
            // bt_ConsultantList
            // 
            this.bt_ConsultantList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ConsultantList.FlatAppearance.BorderSize = 0;
            this.bt_ConsultantList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ConsultantList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_ConsultantList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ConsultantList.Location = new System.Drawing.Point(0, 160);
            this.bt_ConsultantList.Name = "bt_ConsultantList";
            this.bt_ConsultantList.Size = new System.Drawing.Size(200, 60);
            this.bt_ConsultantList.TabIndex = 2;
            this.bt_ConsultantList.Text = "Consultant list";
            this.bt_ConsultantList.UseVisualStyleBackColor = true;
            this.bt_ConsultantList.Click += new System.EventHandler(this.bt_ConsultantList_Click);
            // 
            // bt_CustomerList
            // 
            this.bt_CustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_CustomerList.FlatAppearance.BorderSize = 0;
            this.bt_CustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_CustomerList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_CustomerList.Location = new System.Drawing.Point(0, 100);
            this.bt_CustomerList.Name = "bt_CustomerList";
            this.bt_CustomerList.Size = new System.Drawing.Size(200, 60);
            this.bt_CustomerList.TabIndex = 1;
            this.bt_CustomerList.Text = "Customer list";
            this.bt_CustomerList.UseVisualStyleBackColor = true;
            this.bt_CustomerList.Click += new System.EventHandler(this.bt_CustomerList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.lb_firstNameOfAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 100);
            this.panel2.TabIndex = 1;
            // 
            // lb_firstNameOfAdmin
            // 
            this.lb_firstNameOfAdmin.AutoSize = true;
            this.lb_firstNameOfAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lb_firstNameOfAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_firstNameOfAdmin.Location = new System.Drawing.Point(503, 35);
            this.lb_firstNameOfAdmin.Name = "lb_firstNameOfAdmin";
            this.lb_firstNameOfAdmin.Size = new System.Drawing.Size(294, 39);
            this.lb_firstNameOfAdmin.TabIndex = 1;
            this.lb_firstNameOfAdmin.Text = "firstNameOfAdmin";
            this.lb_firstNameOfAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(329, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1084, 561);
            this.panelDesktop.TabIndex = 2;
            // 
            // AdminsOverviewWindow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminsOverviewWindow_Form";
            this.Text = "OverViewWindow_Form";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bt_CustomerList;
        private System.Windows.Forms.Button bt_LogOut;
        private System.Windows.Forms.Button bt_SpecializationList;
        private System.Windows.Forms.Button bt_ConsultantList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_firstNameOfAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
    }
}