using Presentation.Consultant;
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
    /// <summary>
    /// Djoan
    /// </summary>
    public partial class LogInConsultant_Form : Form
    {
        private BLL.Services.ConsultantService consultantService = new BLL.Services.ConsultantService();

        public LogInConsultant_Form()
        {
            InitializeComponent();
        }

        // Handles the click event of the Go Back button
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handles the link clicked event of the Sign Up as Consultant link label
        private void ll_SignUpAsConsultant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpConsultant_Form signInConsultant_Form = new SignUpConsultant_Form();
            signInConsultant_Form.ShowDialog();
            this.Show();
        }

        // Handles the click event of the Log In as Consultant button
        private void bt_LogInAsConsultant_Click(object sender, EventArgs e)
        {
            // Check if the entered credentials match a valid consultant
            if (consultantService.IsValidConsultant(tb_userNameConsultant.Text, tb_passWordConsultant.Text))
            {
                // Store the logged-in consultant in the ConsultantSingleton instance
                BLL.Singleton.ConsultantSingleton consultantUser = BLL.Singleton.ConsultantSingleton.Instance();
                consultantUser.User = (Abstraction.Interfaces.IConsultant)consultantService.GetConsultant(tb_userNameConsultant.Text, tb_passWordConsultant.Text);

                // Hide the login form and show the consultant overview window
                this.Hide();
                ConsultantOverviewWindow_Form consultantOverviewWindow = new ConsultantOverviewWindow_Form();
                consultantOverviewWindow.ShowDialog();
                this.Show();

                // Clear the username and password textboxes
                tb_userNameConsultant.Clear();
                tb_passWordConsultant.Clear();
            }
            else
            {
                // Display an error message if the credentials do not match any consultant
                MessageBox.Show("The credentials entered does not match any consultant, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
