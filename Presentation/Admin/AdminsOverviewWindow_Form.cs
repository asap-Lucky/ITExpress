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
using Presentation;
using Presentation.Customer;
using Presentation.All;
using Presentation.Admin;
using Abstraction.Interfaces;

namespace Presentation.Consultant
{
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class AdminsOverviewWindow_Form : Form
    {
        //Fields
        Button lastClickedButton = null;

        public Form currentChildForm;

        private Abstraction.Interfaces.IAdmin loggedInAdmin;


        //Constructor
        public AdminsOverviewWindow_Form()
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.loggedInAdmin = BLL.Singleton.AdminSingleton.Instance().User;
            lb_firstNameOfAdmin.Text = loggedInAdmin.Login;
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

        /// <summary>
        /// Logic behind the childforms which are displayed in the parentform (this form).
        /// It looks if a childform is already open, if so it closes it and opens the new childform.
        /// </summary>
        /// <param name="childform"></param>
        public void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                // Creates only one instance of the form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelAdminDesktop.Controls.Add(childform);
            panelAdminDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        //Logout button
        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The methods below are for the buttons are the logic behind clickevents for the buttons on the left in the designer.
        /// They decide which form is opened when a button is clicked upon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_CustomerList_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new AllCustomerOverview_Form());
            this.Show();
        }

        private void bt_ConsultantList_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new AllConsultantOverview_Form());
        }

        private void bt_SpecializationList_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new EditSpecialization_Form());
        }

        private void bt_ProjectList_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            IProjectService projectService = new BLL.Services.ProjectService();
            ICustomer customer = new BLL.Models.Customer();
            OpenChildForm(new AllProjectsOverview_Form(projectService, customer));
        }
    }
}

