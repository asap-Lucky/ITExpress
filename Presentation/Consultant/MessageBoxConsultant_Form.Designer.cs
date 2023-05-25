namespace Presentation.Customer
{
    partial class MessageBoxConsultant
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
            this.bt_openMessage = new System.Windows.Forms.Button();
            this.bt_writeMessage = new System.Windows.Forms.Button();
            this.dgv_MessageDisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MessageDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_openMessage
            // 
            this.bt_openMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_openMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_openMessage.FlatAppearance.BorderSize = 0;
            this.bt_openMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_openMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_openMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_openMessage.Location = new System.Drawing.Point(33, 85);
            this.bt_openMessage.Name = "bt_openMessage";
            this.bt_openMessage.Size = new System.Drawing.Size(205, 30);
            this.bt_openMessage.TabIndex = 20;
            this.bt_openMessage.Text = "Open message";
            this.bt_openMessage.UseVisualStyleBackColor = false;
            this.bt_openMessage.Click += new System.EventHandler(this.bt_openMessage_Click);
            // 
            // bt_writeMessage
            // 
            this.bt_writeMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_writeMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_writeMessage.FlatAppearance.BorderSize = 0;
            this.bt_writeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_writeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_writeMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_writeMessage.Location = new System.Drawing.Point(33, 148);
            this.bt_writeMessage.Name = "bt_writeMessage";
            this.bt_writeMessage.Size = new System.Drawing.Size(205, 30);
            this.bt_writeMessage.TabIndex = 19;
            this.bt_writeMessage.Text = "Write message";
            this.bt_writeMessage.UseVisualStyleBackColor = false;
            // 
            // dgv_MessageDisplay
            // 
            this.dgv_MessageDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MessageDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MessageDisplay.Location = new System.Drawing.Point(0, 73);
            this.dgv_MessageDisplay.Name = "dgv_MessageDisplay";
            this.dgv_MessageDisplay.Size = new System.Drawing.Size(765, 460);
            this.dgv_MessageDisplay.TabIndex = 23;
            this.dgv_MessageDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_newMessages_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Controls.Add(this.dgv_MessageDisplay);
            this.panel1.Location = new System.Drawing.Point(300, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 533);
            this.panel1.TabIndex = 24;
            // 
            // lb_LogInSign
            // 
            this.lb_LogInSign.AutoSize = true;
            this.lb_LogInSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.lb_LogInSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lb_LogInSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LogInSign.Location = new System.Drawing.Point(306, 18);
            this.lb_LogInSign.Name = "lb_LogInSign";
            this.lb_LogInSign.Size = new System.Drawing.Size(172, 39);
            this.lb_LogInSign.TabIndex = 24;
            this.lb_LogInSign.Text = "Messages";
            this.lb_LogInSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SaveChanges.FlatAppearance.BorderSize = 0;
            this.bt_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SaveChanges.Location = new System.Drawing.Point(33, 436);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(205, 30);
            this.bt_SaveChanges.TabIndex = 26;
            this.bt_SaveChanges.Text = "Save changes";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            this.bt_SaveChanges.Click += new System.EventHandler(this.bt_SaveChanges_Click);
            // 
            // MessageBoxConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_openMessage);
            this.Controls.Add(this.bt_writeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxConsultant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MessageDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_openMessage;
        private System.Windows.Forms.Button bt_writeMessage;
        private System.Windows.Forms.DataGridView dgv_MessageDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_LogInSign;
        private System.Windows.Forms.Button bt_SaveChanges;
    }
}