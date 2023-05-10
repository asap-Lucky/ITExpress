namespace Presentation.Costumer
{
    partial class MessageBoxCustumer
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
            this.dgv_existingProjectsCustomer = new System.Windows.Forms.DataGridView();
            this.bt_openMessage = new System.Windows.Forms.Button();
            this.bt_writeMessage = new System.Windows.Forms.Button();
            this.bt_deleteMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_existingProjectsCustomer
            // 
            this.dgv_existingProjectsCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existingProjectsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existingProjectsCustomer.Location = new System.Drawing.Point(313, 65);
            this.dgv_existingProjectsCustomer.Name = "dgv_existingProjectsCustomer";
            this.dgv_existingProjectsCustomer.Size = new System.Drawing.Size(755, 480);
            this.dgv_existingProjectsCustomer.TabIndex = 21;
            // 
            // bt_openMessage
            // 
            this.bt_openMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_openMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_openMessage.FlatAppearance.BorderSize = 0;
            this.bt_openMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_openMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_openMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_openMessage.Location = new System.Drawing.Point(33, 266);
            this.bt_openMessage.Name = "bt_openMessage";
            this.bt_openMessage.Size = new System.Drawing.Size(205, 30);
            this.bt_openMessage.TabIndex = 20;
            this.bt_openMessage.Text = "Open message";
            this.bt_openMessage.UseVisualStyleBackColor = false;
            // 
            // bt_writeMessage
            // 
            this.bt_writeMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_writeMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_writeMessage.FlatAppearance.BorderSize = 0;
            this.bt_writeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_writeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_writeMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_writeMessage.Location = new System.Drawing.Point(33, 139);
            this.bt_writeMessage.Name = "bt_writeMessage";
            this.bt_writeMessage.Size = new System.Drawing.Size(205, 30);
            this.bt_writeMessage.TabIndex = 19;
            this.bt_writeMessage.Text = "Write message";
            this.bt_writeMessage.UseVisualStyleBackColor = false;
            // 
            // bt_deleteMessage
            // 
            this.bt_deleteMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_deleteMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_deleteMessage.FlatAppearance.BorderSize = 0;
            this.bt_deleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deleteMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deleteMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_deleteMessage.Location = new System.Drawing.Point(33, 398);
            this.bt_deleteMessage.Name = "bt_deleteMessage";
            this.bt_deleteMessage.Size = new System.Drawing.Size(205, 30);
            this.bt_deleteMessage.TabIndex = 22;
            this.bt_deleteMessage.Text = "Delete message";
            this.bt_deleteMessage.UseVisualStyleBackColor = false;
            // 
            // MessageBoxCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 557);
            this.ControlBox = false;
            this.Controls.Add(this.bt_deleteMessage);
            this.Controls.Add(this.dgv_existingProjectsCustomer);
            this.Controls.Add(this.bt_openMessage);
            this.Controls.Add(this.bt_writeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxCustumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateNewProject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existingProjectsCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_existingProjectsCustomer;
        private System.Windows.Forms.Button bt_openMessage;
        private System.Windows.Forms.Button bt_writeMessage;
        private System.Windows.Forms.Button bt_deleteMessage;
    }
}