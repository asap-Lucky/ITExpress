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
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.tb_From = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BodyMessage = new System.Windows.Forms.TextBox();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonRespond = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxTo);
            this.panel1.Controls.Add(this.tb_From);
            this.panel1.Controls.Add(this.labelFrom);
            this.panel1.Controls.Add(this.labelTo);
            this.panel1.Controls.Add(this.tb_Title);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 128);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(47, 54);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(499, 21);
            this.comboBoxTo.TabIndex = 8;
            // 
            // tb_From
            // 
            this.tb_From.Location = new System.Drawing.Point(47, 95);
            this.tb_From.Name = "tb_From";
            this.tb_From.Size = new System.Drawing.Size(501, 20);
            this.tb_From.TabIndex = 7;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFrom.Location = new System.Drawing.Point(6, 95);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(36, 15);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTo.Location = new System.Drawing.Point(7, 54);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 15);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(45, 13);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(501, 20);
            this.tb_Title.TabIndex = 3;
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
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSend.Location = new System.Drawing.Point(465, 413);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(105, 30);
            this.buttonSend.TabIndex = 33;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonRespond
            // 
            this.buttonRespond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.buttonRespond.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRespond.FlatAppearance.BorderSize = 0;
            this.buttonRespond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRespond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRespond.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRespond.Location = new System.Drawing.Point(354, 413);
            this.buttonRespond.Name = "buttonRespond";
            this.buttonRespond.Size = new System.Drawing.Size(105, 30);
            this.buttonRespond.TabIndex = 34;
            this.buttonRespond.Text = "Respond";
            this.buttonRespond.UseVisualStyleBackColor = false;
            this.buttonRespond.Click += new System.EventHandler(this.buttonRespond_Click);
            // 
            // ConsultantMessage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.buttonRespond);
            this.Controls.Add(this.buttonSend);
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
        private System.Windows.Forms.TextBox tb_From;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_BodyMessage;
        private System.Windows.Forms.Button bt_GoBack;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonRespond;
        private System.Windows.Forms.ComboBox comboBoxTo;
    }
}