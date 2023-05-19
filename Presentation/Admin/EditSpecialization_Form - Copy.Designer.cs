namespace Presentation.Admin
{
    partial class EditSpecialization_Form
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
            this.dgv_allLanguages = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_EditLanguages = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            this.bt_AddLanguage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_allLanguages);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(263, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 426);
            this.panel1.TabIndex = 29;
            // 
            // dgv_allLanguages
            // 
            this.dgv_allLanguages.AllowUserToAddRows = false;
            this.dgv_allLanguages.AllowUserToDeleteRows = false;
            this.dgv_allLanguages.AllowUserToResizeColumns = false;
            this.dgv_allLanguages.AllowUserToResizeRows = false;
            this.dgv_allLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allLanguages.Location = new System.Drawing.Point(17, 77);
            this.dgv_allLanguages.MultiSelect = false;
            this.dgv_allLanguages.Name = "dgv_allLanguages";
            this.dgv_allLanguages.ReadOnly = true;
            this.dgv_allLanguages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_allLanguages.Size = new System.Drawing.Size(445, 335);
            this.dgv_allLanguages.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Languages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(181, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specialization";
            // 
            // bt_EditLanguages
            // 
            this.bt_EditLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_EditLanguages.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_EditLanguages.FlatAppearance.BorderSize = 0;
            this.bt_EditLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditLanguages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_EditLanguages.Location = new System.Drawing.Point(26, 145);
            this.bt_EditLanguages.Name = "bt_EditLanguages";
            this.bt_EditLanguages.Size = new System.Drawing.Size(177, 30);
            this.bt_EditLanguages.TabIndex = 32;
            this.bt_EditLanguages.Text = "Edit languages";
            this.bt_EditLanguages.UseVisualStyleBackColor = false;
            this.bt_EditLanguages.Click += new System.EventHandler(this.bt_EditLanguages_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.bt_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_delete.Location = new System.Drawing.Point(26, 335);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(177, 30);
            this.bt_delete.TabIndex = 33;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_SaveChanges.FlatAppearance.BorderSize = 0;
            this.bt_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SaveChanges.Location = new System.Drawing.Point(26, 240);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(177, 30);
            this.bt_SaveChanges.TabIndex = 34;
            this.bt_SaveChanges.Text = "Save changes";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            this.bt_SaveChanges.Click += new System.EventHandler(this.bt_SaveChanges_Click);
            // 
            // bt_AddLanguage
            // 
            this.bt_AddLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bt_AddLanguage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddLanguage.FlatAppearance.BorderSize = 0;
            this.bt_AddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_AddLanguage.Location = new System.Drawing.Point(26, 61);
            this.bt_AddLanguage.Name = "bt_AddLanguage";
            this.bt_AddLanguage.Size = new System.Drawing.Size(177, 30);
            this.bt_AddLanguage.TabIndex = 35;
            this.bt_AddLanguage.Text = "Add language";
            this.bt_AddLanguage.UseVisualStyleBackColor = false;
            this.bt_AddLanguage.Click += new System.EventHandler(this.bt_AddLanguage_Click);
            // 
            // EditSpecialization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.bt_AddLanguage);
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_EditLanguages);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(775, 489);
            this.MinimumSize = new System.Drawing.Size(775, 489);
            this.Name = "EditSpecialization_Form";
            this.Text = "Specialization_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allLanguages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_EditLanguages;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_allLanguages;
        private System.Windows.Forms.Button bt_SaveChanges;
        private System.Windows.Forms.Button bt_AddLanguage;
    }
}