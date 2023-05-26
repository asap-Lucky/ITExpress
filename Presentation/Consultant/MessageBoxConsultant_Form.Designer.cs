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
            this.dgv_newMessages = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_LogInSign = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_currentConversations = new System.Windows.Forms.DataGridView();
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newMessages)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentConversations)).BeginInit();
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
            this.bt_openMessage.Location = new System.Drawing.Point(44, 105);
            this.bt_openMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_openMessage.Name = "bt_openMessage";
            this.bt_openMessage.Size = new System.Drawing.Size(273, 37);
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
            this.bt_writeMessage.Location = new System.Drawing.Point(44, 182);
            this.bt_writeMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_writeMessage.Name = "bt_writeMessage";
            this.bt_writeMessage.Size = new System.Drawing.Size(273, 37);
            this.bt_writeMessage.TabIndex = 19;
            this.bt_writeMessage.Text = "Write message";
            this.bt_writeMessage.UseVisualStyleBackColor = false;
            this.bt_writeMessage.Click += new System.EventHandler(this.bt_writeMessage_Click_1);
            // 
            // dgv_newMessages
            // 
            this.dgv_newMessages.BackgroundColor = System.Drawing.Color.White;
            this.dgv_newMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_newMessages.Location = new System.Drawing.Point(0, 90);
            this.dgv_newMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_newMessages.Name = "dgv_newMessages";
            this.dgv_newMessages.RowHeadersWidth = 51;
            this.dgv_newMessages.Size = new System.Drawing.Size(479, 566);
            this.dgv_newMessages.TabIndex = 23;
            this.dgv_newMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_newMessages_CellContentClick);
            this.dgv_newMessages.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_newMessages_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_LogInSign);
            this.panel1.Controls.Add(this.dgv_newMessages);
            this.panel1.Location = new System.Drawing.Point(400, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 656);
            this.panel1.TabIndex = 24;
            // 
            // lb_LogInSign
            // 
            this.lb_LogInSign.AutoSize = true;
            this.lb_LogInSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.lb_LogInSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lb_LogInSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LogInSign.Location = new System.Drawing.Point(64, 22);
            this.lb_LogInSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LogInSign.Name = "lb_LogInSign";
            this.lb_LogInSign.Size = new System.Drawing.Size(304, 48);
            this.lb_LogInSign.TabIndex = 24;
            this.lb_LogInSign.Text = "New messages";
            this.lb_LogInSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_currentConversations);
            this.panel2.Location = new System.Drawing.Point(945, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 656);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Current conversations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_currentConversations
            // 
            this.dgv_currentConversations.BackgroundColor = System.Drawing.Color.White;
            this.dgv_currentConversations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentConversations.Location = new System.Drawing.Point(0, 90);
            this.dgv_currentConversations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_currentConversations.Name = "dgv_currentConversations";
            this.dgv_currentConversations.RowHeadersWidth = 51;
            this.dgv_currentConversations.Size = new System.Drawing.Size(479, 566);
            this.dgv_currentConversations.TabIndex = 24;
            this.dgv_currentConversations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_currentConversations_CellContentClick);
            this.dgv_currentConversations.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_currentConversations_DataBindingComplete);
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SaveChanges.FlatAppearance.BorderSize = 0;
            this.bt_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SaveChanges.Location = new System.Drawing.Point(44, 537);
            this.bt_SaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(273, 37);
            this.bt_SaveChanges.TabIndex = 26;
            this.bt_SaveChanges.Text = "Save changes";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            // 
            // MessageBoxConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1440, 686);
            this.ControlBox = false;
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_openMessage);
            this.Controls.Add(this.bt_writeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MessageBoxConsultant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newMessages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentConversations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_openMessage;
        private System.Windows.Forms.Button bt_writeMessage;
        private System.Windows.Forms.DataGridView dgv_newMessages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_currentConversations;
        private System.Windows.Forms.Label lb_LogInSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_SaveChanges;
    }
}