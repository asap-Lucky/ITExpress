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

namespace Presentation.Costumer
{
    public partial class OverViewWindow_Form : Form
    {
        Button lastClickedButton = null;

        public OverViewWindow_Form()
        {
            InitializeComponent();
            IsMdiContainer = true;
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

        private void bt_createNewProject_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);

            //Logic that prevents the forms from creating more than one instance of the child form.
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CreateNewProject_Form))
                {
                    form.Activate();
                    return;
                }
            }

            //Logic that creats the child form (createNewProject_Form) in the parent form (overViewWindow_Form)
            CreateNewProject_Form childform = new CreateNewProject_Form();
            childform.MdiParent = this;
            childform.StartPosition = FormStartPosition.CenterParent;
            childform.Show();
        }
     
        private void bt_existingProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
        }

        private void bt_closedProjects_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
        }

        private void bt_searchConsultant_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
        }

        private void bt_editProfile_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
        }

        private void bt_Messages_Click(object sender, EventArgs e)
        {
            // Logic behind the button color change
            Button button = (Button)sender;
            buttonColorChange_Click(button);
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.Main_Form main_Form = new UI.Main_Form();
            main_Form.ShowDialog();
            this.Show();
        }

  

    }
   
}
