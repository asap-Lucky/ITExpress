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
    public partial class SignUpConsultant_Form : Form
    {
        public SignUpConsultant_Form()
        {
            InitializeComponent();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
