﻿namespace Presentation.Customer
{
    partial class CustomerOverviewWindow_Form
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
            this.lb_InvitationNotification = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Messages = new System.Windows.Forms.Button();
            this.bt_LogOut = new System.Windows.Forms.Button();
            this.bt_editProfile = new System.Windows.Forms.Button();
            this.bt_searchConsultant = new System.Windows.Forms.Button();
            this.bt_closedProjects = new System.Windows.Forms.Button();
            this.bt_existingProjects = new System.Windows.Forms.Button();
            this.bt_createNewProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_firstNameOfCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lb_MessageNotification = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.lb_MessageNotification);
            this.panelMenu.Controls.Add(this.lb_InvitationNotification);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.bt_Messages);
            this.panelMenu.Controls.Add(this.bt_LogOut);
            this.panelMenu.Controls.Add(this.bt_editProfile);
            this.panelMenu.Controls.Add(this.bt_searchConsultant);
            this.panelMenu.Controls.Add(this.bt_closedProjects);
            this.panelMenu.Controls.Add(this.bt_existingProjects);
            this.panelMenu.Controls.Add(this.bt_createNewProject);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 814);
            this.panelMenu.TabIndex = 0;
            // 
            // lb_InvitationNotification
            // 
            this.lb_InvitationNotification.AutoSize = true;
            this.lb_InvitationNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InvitationNotification.ForeColor = System.Drawing.Color.Red;
            this.lb_InvitationNotification.Location = new System.Drawing.Point(196, 592);
            this.lb_InvitationNotification.Name = "lb_InvitationNotification";
            this.lb_InvitationNotification.Size = new System.Drawing.Size(64, 25);
            this.lb_InvitationNotification.TabIndex = 10;
            this.lb_InvitationNotification.Text = "label2";
            this.lb_InvitationNotification.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "Invitations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Messages
            // 
            this.bt_Messages.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Messages.FlatAppearance.BorderSize = 0;
            this.bt_Messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_Messages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Messages.Location = new System.Drawing.Point(0, 493);
            this.bt_Messages.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Messages.Name = "bt_Messages";
            this.bt_Messages.Size = new System.Drawing.Size(267, 74);
            this.bt_Messages.TabIndex = 8;
            this.bt_Messages.Text = "Messages";
            this.bt_Messages.UseVisualStyleBackColor = true;
            this.bt_Messages.Click += new System.EventHandler(this.bt_Messages_Click);
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.bt_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_LogOut.FlatAppearance.BorderSize = 0;
            this.bt_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LogOut.Location = new System.Drawing.Point(0, 740);
            this.bt_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.Size = new System.Drawing.Size(267, 74);
            this.bt_LogOut.TabIndex = 7;
            this.bt_LogOut.Text = "Log out";
            this.bt_LogOut.UseVisualStyleBackColor = false;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            // 
            // bt_editProfile
            // 
            this.bt_editProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_editProfile.FlatAppearance.BorderSize = 0;
            this.bt_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_editProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_editProfile.Location = new System.Drawing.Point(0, 419);
            this.bt_editProfile.Margin = new System.Windows.Forms.Padding(4);
            this.bt_editProfile.Name = "bt_editProfile";
            this.bt_editProfile.Size = new System.Drawing.Size(267, 74);
            this.bt_editProfile.TabIndex = 5;
            this.bt_editProfile.Text = "Edit profile";
            this.bt_editProfile.UseVisualStyleBackColor = true;
            this.bt_editProfile.Click += new System.EventHandler(this.bt_editProfile_Click);
            // 
            // bt_searchConsultant
            // 
            this.bt_searchConsultant.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_searchConsultant.FlatAppearance.BorderSize = 0;
            this.bt_searchConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_searchConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_searchConsultant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_searchConsultant.Location = new System.Drawing.Point(0, 345);
            this.bt_searchConsultant.Margin = new System.Windows.Forms.Padding(4);
            this.bt_searchConsultant.Name = "bt_searchConsultant";
            this.bt_searchConsultant.Size = new System.Drawing.Size(267, 74);
            this.bt_searchConsultant.TabIndex = 4;
            this.bt_searchConsultant.Text = "Search consultant";
            this.bt_searchConsultant.UseVisualStyleBackColor = true;
            this.bt_searchConsultant.Click += new System.EventHandler(this.bt_searchConsultant_Click);
            // 
            // bt_closedProjects
            // 
            this.bt_closedProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_closedProjects.FlatAppearance.BorderSize = 0;
            this.bt_closedProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_closedProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_closedProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_closedProjects.Location = new System.Drawing.Point(0, 271);
            this.bt_closedProjects.Margin = new System.Windows.Forms.Padding(4);
            this.bt_closedProjects.Name = "bt_closedProjects";
            this.bt_closedProjects.Size = new System.Drawing.Size(267, 74);
            this.bt_closedProjects.TabIndex = 3;
            this.bt_closedProjects.Text = "Closed projects";
            this.bt_closedProjects.UseVisualStyleBackColor = true;
            this.bt_closedProjects.Click += new System.EventHandler(this.bt_closedProjects_Click);
            // 
            // bt_existingProjects
            // 
            this.bt_existingProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_existingProjects.FlatAppearance.BorderSize = 0;
            this.bt_existingProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_existingProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_existingProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_existingProjects.Location = new System.Drawing.Point(0, 197);
            this.bt_existingProjects.Margin = new System.Windows.Forms.Padding(4);
            this.bt_existingProjects.Name = "bt_existingProjects";
            this.bt_existingProjects.Size = new System.Drawing.Size(267, 74);
            this.bt_existingProjects.TabIndex = 2;
            this.bt_existingProjects.Text = "Existing projects";
            this.bt_existingProjects.UseVisualStyleBackColor = true;
            this.bt_existingProjects.Click += new System.EventHandler(this.bt_existingProjects_Click);
            // 
            // bt_createNewProject
            // 
            this.bt_createNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_createNewProject.FlatAppearance.BorderSize = 0;
            this.bt_createNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_createNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_createNewProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_createNewProject.Location = new System.Drawing.Point(0, 123);
            this.bt_createNewProject.Margin = new System.Windows.Forms.Padding(4);
            this.bt_createNewProject.Name = "bt_createNewProject";
            this.bt_createNewProject.Size = new System.Drawing.Size(267, 74);
            this.bt_createNewProject.TabIndex = 1;
            this.bt_createNewProject.Text = "Create new project";
            this.bt_createNewProject.UseVisualStyleBackColor = true;
            this.bt_createNewProject.Click += new System.EventHandler(this.bt_createNewProject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(267, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 123);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.lb_firstNameOfCustomer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 123);
            this.panel2.TabIndex = 1;
            // 
            // lb_firstNameOfCustomer
            // 
            this.lb_firstNameOfCustomer.AutoSize = true;
            this.lb_firstNameOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lb_firstNameOfCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_firstNameOfCustomer.Location = new System.Drawing.Point(671, 43);
            this.lb_firstNameOfCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_firstNameOfCustomer.Name = "lb_firstNameOfCustomer";
            this.lb_firstNameOfCustomer.Size = new System.Drawing.Size(426, 48);
            this.lb_firstNameOfCustomer.TabIndex = 1;
            this.lb_firstNameOfCustomer.Text = "firstNameOfCustomer";
            this.lb_firstNameOfCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(439, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(267, 123);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1445, 691);
            this.panelDesktop.TabIndex = 2;
            // 
            // lb_MessageNotification
            // 
            this.lb_MessageNotification.AutoSize = true;
            this.lb_MessageNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MessageNotification.ForeColor = System.Drawing.Color.Red;
            this.lb_MessageNotification.Location = new System.Drawing.Point(196, 518);
            this.lb_MessageNotification.Name = "lb_MessageNotification";
            this.lb_MessageNotification.Size = new System.Drawing.Size(64, 25);
            this.lb_MessageNotification.TabIndex = 11;
            this.lb_MessageNotification.Text = "label2";
            this.lb_MessageNotification.Visible = false;
            // 
            // CustomerOverviewWindow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1712, 814);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerOverviewWindow_Form";
            this.Text = "OverViewWindow_Form";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bt_createNewProject;
        private System.Windows.Forms.Button bt_LogOut;
        private System.Windows.Forms.Button bt_editProfile;
        private System.Windows.Forms.Button bt_searchConsultant;
        private System.Windows.Forms.Button bt_closedProjects;
        private System.Windows.Forms.Button bt_existingProjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_firstNameOfCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Messages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_InvitationNotification;
        private System.Windows.Forms.Label lb_MessageNotification;
    }
}