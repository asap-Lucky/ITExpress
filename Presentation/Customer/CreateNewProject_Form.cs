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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.Customer
{ /// <summary>
/// VIljo
/// </summary>
    public partial class CreateNewProject_Form : Form
    {
        private Abstraction.Interfaces.ICustomer loggedInCustomer;
        public Abstraction.Interfaces.IProject MyProject { get; set; }
        BLL.Services.ProjectService ProjectService = new BLL.Services.ProjectService();
        ICodeLangaugeService codeLanguageService = new BLL.Services.CodeLanguageService();
        ICustomerService customerService = new BLL.Services.CustomerService();

        BLL.Facader.CustomerService FacadeService;


        IEndtypeService endtypeService = new BLL.Services.EndtypeService();


        /// <summary>
        /// Constructor for CreateNewProject_Form
        /// </summary>
        public CreateNewProject_Form(ICustomer loggedincustomer)
        {
            InitializeComponent();
            InitializeCombobox();
            this.loggedInCustomer = loggedincustomer;
            FacadeService = new BLL.Facader.CustomerService(customerService);

            MyProject = new Project();
        }
        /// <summary>
        /// Register the project
        /// </summary>
        private void RegisterProject()
        {
            bool canParseHourWage = decimal.TryParse(tb_projectHourWage.Text, out decimal hourWage);

            if (!canParseHourWage)
            {
                MessageBox.Show("Please only use numbers for the Project!", "Invalid Project!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                loggedInCustomer = FacadeService.GetCustomer(loggedInCustomer.Id);
                MyProject.Name = tb_projectName.Text;
                MyProject.Description = tb_projectDescription.Text.ToString();
                MyProject.HourWage = hourWage;
                MyProject.StartDate = dtp_startDate.Value;
                MyProject.EndDate = dtp_endDate.Value;
                MyProject.Language = (ICodeLanguage)cb_projectRequierements.SelectedItem;
                MyProject.EndType = (IEndType)cb_projectEndtype.SelectedItem;
                MyProject.Customer = loggedInCustomer;



                ProjectService.AddProject(MyProject);
            }
        }

        /// <summary>
        /// Initialize the comboboxes
        /// </summary>
        private void InitializeCombobox()
        {
            cb_projectRequierements.DataSource = codeLanguageService.GetAllCodeLanguages();
            cb_projectRequierements.DisplayMember = "Language";
            cb_projectRequierements.SelectedIndex = -1;

            cb_projectEndtype.DataSource = endtypeService.GetAllEndTypes();
            cb_projectEndtype.DisplayMember = "EndType1";
            cb_projectEndtype.SelectedIndex = -1;
        }

        private void CreateNewProject_Form_Load_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Save button click event handler
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            
                if (cb_projectRequierements.SelectedItem == null || cb_projectEndtype.SelectedItem == null)
                {
                    MessageBox.Show("You have to choose an End Type and Code Language.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop the save process if the required selections are not made
                }

                RegisterProject();
                DialogResult dialogresult = MessageBox.Show("Project has been created successfully, you may now close this window safely.", "Project created successfully!", MessageBoxButtons.OK);
                if (dialogresult == DialogResult.OK)
                {
                    this.Close();
                }
            
        }

        private void bt_DiscardProject_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to discard all changes to the create project? It will be LOST FOREVER!", "Discard changes?", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                tb_projectName.Clear();
                tb_projectDescription.Clear();
                tb_projectHourWage.Clear();
                cb_projectEndtype.SelectedIndex = -1;
                cb_projectRequierements.SelectedIndex = -1;
                dtp_startDate.Value = DateTime.Now;
                dtp_endDate.Value = DateTime.Now;
            }
        }
    }
}
