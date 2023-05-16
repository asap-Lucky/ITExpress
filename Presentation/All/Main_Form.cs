using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.All;
using UI.Consultant;

namespace UI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

        }

        private void bt_LogInAsCostumer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInAdmin_Form logInCostumer_Form = new LogInCustomer_Form();
            logInCostumer_Form.ShowDialog();
            this.Show();
        }

        private void bt_LogInAsConsultant_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInConsultant_Form logInConsultant = new LogInConsultant_Form();
            logInConsultant.ShowDialog();
            this.Show();
        }

        private void bt_LogInAsAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInAdmin_Form logInConsultant = new LogInAdmin_Form();
            logInConsultant.ShowDialog();
            this.Show();
        }
    }
}
