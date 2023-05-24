namespace Presentation.All
{
    partial class ConsultantMessage_Form
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
            this.tb_SendToReciever = new System.Windows.Forms.TextBox();
            this.tb_FromSenderEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TitleOfMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BodyMessage = new System.Windows.Forms.TextBox();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_SendToReciever);
            this.panel1.Controls.Add(this.tb_FromSenderEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_TitleOfMessage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 128);
            this.panel1.TabIndex = 0;
            // 
            // tb_SendToReciever
            // 
            this.tb_SendToReciever.Location = new System.Drawing.Point(45, 53);
            this.tb_SendToReciever.Name = "tb_SendToReciever";
            this.tb_SendToReciever.Size = new System.Drawing.Size(501, 20);
            this.tb_SendToReciever.TabIndex = 8;
            // 
            // tb_FromSenderEmail
            // 
            this.tb_FromSenderEmail.Location = new System.Drawing.Point(47, 95);
            this.tb_FromSenderEmail.Name = "tb_FromSenderEmail";
            this.tb_FromSenderEmail.Size = new System.Drawing.Size(501, 20);
            this.tb_FromSenderEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // tb_TitleOfMessage
            // 
            this.tb_TitleOfMessage.Location = new System.Drawing.Point(45, 13);
            this.tb_TitleOfMessage.Name = "tb_TitleOfMessage";
            this.tb_TitleOfMessage.Size = new System.Drawing.Size(501, 20);
            this.tb_TitleOfMessage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_BodyMessage);
            this.panel2.Location = new System.Drawing.Point(13, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 255);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Body";
            // 
            // tb_BodyMessage
            // 
            this.tb_BodyMessage.Location = new System.Drawing.Point(9, 24);
            this.tb_BodyMessage.Multiline = true;
            this.tb_BodyMessage.Name = "tb_BodyMessage";
            this.tb_BodyMessage.Size = new System.Drawing.Size(540, 220);
            this.tb_BodyMessage.TabIndex = 0;
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_GoBack.FlatAppearance.BorderSize = 0;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_GoBack.Location = new System.Drawing.Point(12, 413);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(105, 30);
            this.bt_GoBack.TabIndex = 32;
            this.bt_GoBack.Text = "Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            this.bt_GoBack.Click += new System.EventHandler(this.bt_GoBack_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_Send.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Send.FlatAppearance.BorderSize = 0;
            this.bt_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Send.Location = new System.Drawing.Point(465, 413);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(105, 30);
            this.bt_Send.TabIndex = 33;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = false;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click_1);
            // 
            // ConsultantMessage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(599, 489);
            this.MinimumSize = new System.Drawing.Size(599, 489);
            this.Name = "ConsultantMessage_Form";
            this.Text = "Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_FromSenderEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TitleOfMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_BodyMessage;
        private System.Windows.Forms.Button bt_GoBack;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox tb_SendToReciever;
    }
}