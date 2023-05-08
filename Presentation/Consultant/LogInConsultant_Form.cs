using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Consultant
{
    public partial class LogInConsultant_Form : Form
    {
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
    }
}
