namespace Presentation.Admin
{
    partial class AddSpecialization_Form
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
            this.tb_EnterNewLanguage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_EnterNewLanguage
            // 
            this.tb_EnterNewLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_EnterNewLanguage.Location = new System.Drawing.Point(103, 59);
            this.tb_EnterNewLanguage.Name = "tb_EnterNewLanguage";
            this.tb_EnterNewLanguage.Size = new System.Drawing.Size(159, 23);
            this.tb_EnterNewLanguage.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Write language";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_GoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_GoBack.FlatAppearance.BorderSize = 0;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_GoBack.Location = new System.Drawing.Point(12, 103);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(93, 30);
            this.bt_GoBack.TabIndex = 35;
            this.bt_GoBack.Text = "Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SaveChanges.FlatAppearance.BorderSize = 0;
            this.bt_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SaveChanges.Location = new System.Drawing.Point(261, 103);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(93, 30);
            this.bt_SaveChanges.TabIndex = 36;
            this.bt_SaveChanges.Text = "Save changes";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            // 
            // AddSpecialization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(366, 145);
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_EnterNewLanguage);
            this.MaximumSize = new System.Drawing.Size(382, 184);
            this.MinimumSize = new System.Drawing.Size(382, 184);
            this.Name = "AddSpecialization_Form";
            this.Text = "AddSpecialization_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EnterNewLanguage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_GoBack;
        private System.Windows.Forms.Button bt_SaveChanges;
    }
}