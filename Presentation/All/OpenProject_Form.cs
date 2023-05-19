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
        private Abstraction.Interfaces.ICustomer loggedInCustomer;
        public Abstraction.Interfaces.IProject MyProject { get; set; }
        BLL.Services.ProjectService ProjectService = new BLL.Services.ProjectService();
        ICodeLangaugeService codeLanguageService = new BLL.Services.CodeLanguageService();
        ICustomerService customerService = new BLL.Services.CustomerService();

        BLL.Facader.CustomerService FacadeService;

        IEndtypeService endtypeService = new BLL.Services.EndtypeService();
        public EditProjectConsultant_Form(ICustomer loggedincustomer, IProject project)
        {
            InitializeComponent();
            InitializeCombobox();
            this.loggedInCustomer = loggedincustomer;
            FacadeService = new BLL.Facader.CustomerService(customerService);

            MyProject = project;
            LoadProjectData();
        }

        private void LoadProjectData()
        {
            tb_projectName.Text = MyProject.Name;
            tb_projectDescription.Text = MyProject.Description;
            tb_projectHourWage.Text = MyProject.HourWage.ToString();
            dtp_startDate.Value = MyProject.StartDate;
            dtp_endDate.Value = MyProject.EndDate;
            cb_CodeLanguage.SelectedItem = MyProject.Language;
            cb_EndType.SelectedItem = MyProject.EndType;
        }

        private void UpdateProject()
        {
            bool canParseHourWage = decimal.TryParse(tb_projectHourWage.Text, out decimal hourWage);

            if (!canParseHourWage)
            {
                MessageBox.Show("Please only use numbers for the Hourly Wage!", "Invalid Hourly Wage!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loggedInCustomer = FacadeService.GetCustomer(loggedInCustomer.Id);
                MyProject.Name = tb_projectName.Text;
                MyProject.Description = tb_projectDescription.Text;
                MyProject.HourWage = hourWage;
                MyProject.StartDate = dtp_startDate.Value;
                MyProject.EndDate = dtp_endDate.Value;
                MyProject.Language = (ICodeLanguage)cb_CodeLanguage.SelectedItem;
                MyProject.EndType = (IEndType)cb_EndType.SelectedItem;
                MyProject.Customer = loggedInCustomer;

                ProjectService.EditProject(MyProject);
                MessageBox.Show("Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void InitializeCombobox()
        {
            cb_CodeLanguage.DataSource = codeLanguageService.GetAllCodeLanguages();
            cb_CodeLanguage.DisplayMember = "Language";
            cb_CodeLanguage.SelectedIndex = -1;

            cb_EndType.DataSource = endtypeService.GetAllEndTypes();
            cb_EndType.DisplayMember = "EndType1";
            cb_EndType.SelectedIndex = -1;
        }

        private void btn_updateProject_Click(object sender, EventArgs e)
        {
            UpdateProject();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel editing the project?", "Cancel Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }
    }
}

       

        

       

       