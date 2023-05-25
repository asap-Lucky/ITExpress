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
using Abstraction.Interfaces;
using Presentation;
using Presentation.Customer;

namespace Presentation.Customer
{
    public partial class CustomerOverviewWindow_Form : Form
    {
        Button lastClickedButton = null;
        public Form currentChildForm { get; set; }
        private Abstraction.Interfaces.ICustomer loggedInCustomer;
        List<IInvitation> PendingInvitations { get; set; }

        BLL.Services.InvitationService invitationService;

        public CustomerOverviewWindow_Form()
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.loggedInCustomer = BLL.Singleton.CustomerSingleton.Instance().User;
            invitationService = new BLL.Services.InvitationService();
            PendingInvitations = invitationService.GetInvitationsViaCostumer(loggedInCustomer).Where(i => i.AcceptStatus == i.AcceptStatus== false).ToList();
            lb_firstNameOfCustomer.Text = loggedInCustomer.FirstName;
            InvitationNotification();

        }

        public void InvitationNotification()
        {
            if (PendingInvitations.Count == 0)
            {
                lb_InvitationNotification.Visible = false;
            }
            else
            {
                lb_InvitationNotification.Visible = true;
            }
            lb_InvitationNotification.Text = PendingInvitations.Count.ToString();
        }

        /// <summary>
        /// This method creates a color change when a button is clicked upon and changes the color of the button to a 
        /// custom color. Where if another button of the following buttons is clicked it is changed to default color.
        /// It uses the properties "customClickColor" which is green, and "customDefaultColor" which is dark blue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorChange_Click(object sender)
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

        private void OpenChildForm(Form childform)
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

        private void bt_createNewProject_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new CreateNewProject_Form(loggedInCustomer));
        }

        private void bt_closedProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            IProjectService projectService = new BLL.Services.ProjectService();
            OpenChildForm(new ClosedProjects(loggedInCustomer, projectService));
        }

        private void bt_existingProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            IProjectService projectService = new BLL.Services.ProjectService();
            OpenChildForm(new ExistingProjectOverview_Forn(loggedInCustomer, projectService));
        }

        private void bt_searchConsultant_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new SearchConsultant(loggedInCustomer));
        }

        private void bt_editProfile_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new EditProfileCustomer(loggedInCustomer));
        }

        private void bt_Messages_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new MessageBoxCustomer());
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonColorChange_Click(button);
            OpenChildForm(new CustomerInvitationBox_Form()); 
        }
    }
   
}
