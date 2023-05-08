using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Consultant
{
    public partial class LogInConsultant_Form : Form
    {
        private BLL.Services.ConsultantService consultantService = new BLL.Services.ConsultantService();

        public LogInConsultant_Form()
        {
            InitializeComponent();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_SignUpAsConsultant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpConsultant_Form signInConsultant_Form = new SignUpConsultant_Form();
            signInConsultant_Form.ShowDialog();
            this.Show();
        }

        private void bt_LogInAsConsultant_Click(object sender, EventArgs e)
        {
            if (consultantService.IsValidConsultant(tb_userNameConsultant.Text, tb_passWordConsultant.Text))
            {
                BLL.Models.Consultant consultant = (BLL.Models.Consultant)consultantService.GetConsultant(tb_userNameConsultant.Text, tb_passWordConsultant.Text);
                //Send consultant til næste formular
            }
            else
            {
                MessageBox.Show("The credentials entered does not match any consultant, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
