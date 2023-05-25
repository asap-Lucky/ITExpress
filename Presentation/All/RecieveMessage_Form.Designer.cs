namespace Presentation.All
{
    partial class RecieveMessage_Form
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
            this.tb_Sender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Reciver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Header = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Body = new System.Windows.Forms.TextBox();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_Sender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_Reciver);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_Header);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 128);
            this.panel1.TabIndex = 0;
            // 
            // tb_Sender
            // 
            this.tb_Sender.Location = new System.Drawing.Point(47, 95);
            this.tb_Sender.Name = "tb_Sender";
            this.tb_Sender.ReadOnly = true;
            this.tb_Sender.Size = new System.Drawing.Size(501, 20);
            this.tb_Sender.TabIndex = 7;
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
            // tb_Reciver
            // 
            this.tb_Reciver.Location = new System.Drawing.Point(45, 54);
            this.tb_Reciver.Name = "tb_Reciver";
            this.tb_Reciver.ReadOnly = true;
            this.tb_Reciver.Size = new System.Drawing.Size(504, 20);
            this.tb_Reciver.TabIndex = 5;
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
            // tb_Header
            // 
            this.tb_Header.Location = new System.Drawing.Point(45, 13);
            this.tb_Header.Name = "tb_Header";
            this.tb_Header.ReadOnly = true;
            this.tb_Header.Size = new System.Drawing.Size(501, 20);
            this.tb_Header.TabIndex = 3;
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
            this.panel2.Controls.Add(this.tb_Body);
            this.panel2.Location = new System.Drawing.Point(13, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 250);
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
            // tb_Body
            // 
            this.tb_Body.Location = new System.Drawing.Point(9, 24);
            this.tb_Body.Multiline = true;
            this.tb_Body.Name = "tb_Body";
            this.tb_Body.ReadOnly = true;
            this.tb_Body.Size = new System.Drawing.Size(540, 218);
            this.tb_Body.TabIndex = 0;
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_GoBack.FlatAppearance.BorderSize = 0;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_GoBack.Location = new System.Drawing.Point(13, 408);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(105, 30);
            this.bt_GoBack.TabIndex = 31;
            this.bt_GoBack.Text = "Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            // 
            // RecieveMessage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(599, 489);
            this.MinimumSize = new System.Drawing.Size(599, 489);
            this.Name = "RecieveMessage_Form";
            this.Text = "Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Sender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Reciver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Body;
        private System.Windows.Forms.Button bt_GoBack;
    }
}