namespace Presentation.Customer
{
    partial class CustomerInvitationBox_Form
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
            this.bt_acceptInvitation = new System.Windows.Forms.Button();
            this.dgv_newInvitations = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AcceptedInvitations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newInvitations)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AcceptedInvitations)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_acceptInvitation
            // 
            this.bt_acceptInvitation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_acceptInvitation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_acceptInvitation.FlatAppearance.BorderSize = 0;
            this.bt_acceptInvitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_acceptInvitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acceptInvitation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_acceptInvitation.Location = new System.Drawing.Point(33, 163);
            this.bt_acceptInvitation.Name = "bt_acceptInvitation";
            this.bt_acceptInvitation.Size = new System.Drawing.Size(205, 30);
            this.bt_acceptInvitation.TabIndex = 20;
            this.bt_acceptInvitation.Text = "Accept Invitation";
            this.bt_acceptInvitation.UseVisualStyleBackColor = false;
            this.bt_acceptInvitation.Click += new System.EventHandler(this.bt_acceptInvitation_Click);
            // 
            // dgv_newInvitations
            // 
            this.dgv_newInvitations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_newInvitations.BackgroundColor = System.Drawing.Color.White;
            this.dgv_newInvitations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_newInvitations.Location = new System.Drawing.Point(0, 73);
            this.dgv_newInvitations.Name = "dgv_newInvitations";
            this.dgv_newInvitations.Size = new System.Drawing.Size(360, 427);
            this.dgv_newInvitations.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Controls.Add(this.dgv_newInvitations);
            this.panel1.Location = new System.Drawing.Point(341, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 500);
            this.panel1.TabIndex = 24;
            // 
            // lb_LogInSign
            // 
            this.lb_LogInSign.AutoSize = true;
            this.lb_LogInSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.lb_LogInSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_LogInSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LogInSign.Location = new System.Drawing.Point(3, 39);
            this.lb_LogInSign.Name = "lb_LogInSign";
            this.lb_LogInSign.Size = new System.Drawing.Size(184, 31);
            this.lb_LogInSign.TabIndex = 24;
            this.lb_LogInSign.Text = "New invitation";
            this.lb_LogInSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(33, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_AcceptedInvitations);
            this.panel2.Location = new System.Drawing.Point(707, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 500);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Accepted inviations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_AcceptedInvitations
            // 
            this.dgv_AcceptedInvitations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AcceptedInvitations.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AcceptedInvitations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AcceptedInvitations.Location = new System.Drawing.Point(0, 73);
            this.dgv_AcceptedInvitations.Name = "dgv_AcceptedInvitations";
            this.dgv_AcceptedInvitations.Size = new System.Drawing.Size(360, 427);
            this.dgv_AcceptedInvitations.TabIndex = 23;
            // 
            // CustomerInvitationBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_acceptInvitation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInvitationBox_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newInvitations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AcceptedInvitations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_acceptInvitation;
        private System.Windows.Forms.DataGridView dgv_newInvitations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_LogInSign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AcceptedInvitations;
    }
}