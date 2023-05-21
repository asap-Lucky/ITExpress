    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Abstraction.Interfaces;
    using BLL.Facader;
    using BLL.Models;
    using BLL.Services;

    namespace Presentation.Customer
    {
        public partial class EditProjectConsultant_Form : Form
        {
            private ICustomer loggedInCustomer;
            public IProject MyProject { get; set; }
            private BLL.Services.ProjectService projectService = new BLL.Services.ProjectService();
            //private ProjectService projectService = new ProjectService();
            private CodeLanguageService codeLanguageService = new CodeLanguageService();
            //private CustomerService customerService = new CustomerService();
            private EndtypeService endtypeService = new EndtypeService();

            public EditProjectConsultant_Form(ICustomer loggedInCustomer, IProject project)
            {
                this.loggedInCustomer = loggedInCustomer;
                MyProject = project;
                InitializeComponent();
                DisableEditing();
                InitializeComboBoxes();
                LoadProjectData();
        }

        private void LoadProjectData()
        {
            tb_projectName.Text = MyProject.Name;
            tb_projectDescription.Text = MyProject.Description;
            tb_projectHourWage.Text = MyProject.HourWage.ToString();
            dtp_startDate.Value = MyProject.StartDate;
            dtp_endDate.Value = MyProject.EndDate;
            cb_CodeLanguage.SelectedItem = MyProject.Language.Language;
            cb_EndType.SelectedItem = MyProject.EndType.EndType1;

            if (MyProject.TimeUsed != 0)
            {
                tb_HoursSpent.Text = MyProject.TimeUsed.ToString();

                int hoursSpent = MyProject.TimeUsed;
                decimal hourWage = MyProject.HourWage;
                decimal totalPay = hoursSpent * hourWage;

                MyProject.TotalSum = totalPay;  // Update the TotalSum property with the calculated value

                tb_TotalPay.Text = MyProject.TotalSum.ToString();

            }
                tb_TotalPay.Enabled = false;
        }

        public void DisableEditing()
        {
            tb_projectName.Enabled = false;
            tb_projectDescription.Enabled = false;
            tb_projectHourWage.Enabled = false;
            dtp_startDate.Enabled = false;
            dtp_endDate.Enabled = false;
            cb_CodeLanguage.Enabled = false;
            cb_EndType.Enabled = false;

            if (MyProject.Language != null)
            {
                cb_CodeLanguage.SelectedIndex = cb_CodeLanguage.FindStringExact(MyProject.Language.Language);
            }

            if (MyProject.EndType != null)
            {
                cb_EndType.SelectedIndex = cb_EndType.FindStringExact(MyProject.EndType.EndType1);
            }
        
        }

            public void DisableHours()
            {
                tb_HoursSpent.Enabled = false;
            }



            private void InitializeComboBoxes()
            {
                cb_CodeLanguage.DataSource = codeLanguageService.GetAllCodeLanguages();
                cb_CodeLanguage.DisplayMember = "Language";
                cb_CodeLanguage.SelectedIndex = -1;

                cb_EndType.DataSource = endtypeService.GetAllEndTypes();
                cb_EndType.DisplayMember = "EndType1";
                cb_EndType.SelectedIndex = -1;
            }

            private void bt_GoBack_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Are you sure you want to close this window?", "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                this.Close();
            }

            private void bt_SaveChanges_Click(object sender, EventArgs e)
            {
                SaveBillableHours();
            }

            private void SaveBillableHours()
            {
                int hoursSpent;
                if (int.TryParse(tb_HoursSpent.Text, out hoursSpent))
                {
                    MyProject.TimeUsed = hoursSpent;
                    projectService.EditProject(MyProject);

                    MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid input for hours spent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }
    }
