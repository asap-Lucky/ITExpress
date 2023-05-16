using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Consultant;
using Presentation.All;
using Presentation.Customer;

namespace Presentation.Consultant
{
    public partial class ConsultantOverviewWindow_Form : Form
    {
        Button lastClickedButton = null;

        public Form currentChildForm { get; set; }

        private Abstraction.Interfaces.IConsultant loggedInConsultant;

        public ConsultantOverviewWindow_Form(Abstraction.Interfaces.IConsultant consultant)
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.loggedInConsultant = consultant;
            lb_firstNameOfCustomer.Text = loggedInConsultant.FirstName;
        }

        /// <summary>
        /// This method creates a color change when a button is clicked upon and changes the color of the button to a 
        /// custom color. Where if another button of the following buttons is clicked it is changed to default color.
        /// It uses the properties "customClickColor" which is green, and "customDefaultColor" which is dark blue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonColorChange_Click(object sender)
        {
            Color customClickColor = Color.FromArgb(26, 177, 136);
            Color customDefaultColor = Color.FromArgb(50, 51, 76);

            Button clickedButton = (Button)sender;

            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = customDefaultColor; // change the color of the last clicked button back to default
            }

            clickedButton.BackColor = customClickColor; // change the color of the clicked button to the custom color

            lastClickedButton = clickedButton; // remember the current clicked button
        }


        public void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                // Opems only one instance of the form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void bt_searchProject_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new SearchProjects());
        }

        private void bt_currentProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new CurrentProjects_Form());
        }

        private void bt_closedProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new ConsultantClosedProjects());
        }

        private void bt_editProfile_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new EditProfileConsultant(loggedInConsultant));
        }

        private void bt_Messages_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new MessageBoxConsultant());
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_InvitationBox_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new InvitationBox_Form());
        }
    }
}

