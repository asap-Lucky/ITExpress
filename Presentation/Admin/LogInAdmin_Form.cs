using BLL.Services;
using Presentation.Consultant;
using Presentation.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Costumer;

namespace UI.All
{
    public partial class LogInAdmin_Form : Form
    {
        
        private BLL.Services.AdminService adminService = new BLL.Services.AdminService();

        public LogInAdmin_Form()
        {
            InitializeComponent();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_LogInAsAdmin_Click(object sender, EventArgs e)
        {
            if (adminService.IsValidAdmin(tb_userNameAdmin.Text, tb_passWordAdmin.Text))
            {
                Abstraction.Interfaces.IAdmin admin = (Abstraction.Interfaces.IAdmin)adminService.GetAdmin(tb_userNameAdmin.Text, tb_passWordAdmin.Text);

                this.Hide();
                AdminsOverviewWindow_Form overViewWindow_Form = new AdminsOverviewWindow_Form();
                overViewWindow_Form.ShowDialog();
                this.Show();
                tb_passWordAdmin.Clear();
                tb_userNameAdmin.Clear();
            }
            else
            {
                MessageBox.Show("The credentials entered does not match any admin, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_GoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form main_Form = new Main_Form();
            main_Form.ShowDialog();
            
        }
    }
}

