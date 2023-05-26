using BLL.Facader;
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
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class LogInAdmin_Form : Form
    {
        //Fields
        private BLL.Services.AdminService adminService = new BLL.Services.AdminService();

        //Constructor
        public LogInAdmin_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method takes the admin to the next form if the credentials are correct. It checks using a method from the admin service
        /// if the admin credentials are valid. If yes, then it uses the admin singleton which is a singular instance of the admin user
        /// which is used to keep track of the admin user throughout the program. It then hides the current form and opens the next form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="adminUser"></param> - parameter for the admin user singleton
        private void bt_LogInAsAdmin_Click(object sender, EventArgs e)
        {
            if (adminService.IsValidAdmin(tb_userNameAdmin.Text, tb_passWordAdmin.Text))
            {
                BLL.Singleton.AdminSingleton adminUser = BLL.Singleton.AdminSingleton.Instance();
                adminUser.User = (Abstraction.Interfaces.IAdmin)adminService.GetAdmin(tb_userNameAdmin.Text, tb_passWordAdmin.Text);

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

        //Go back button
        private void bt_GoBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

