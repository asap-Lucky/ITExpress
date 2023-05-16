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
using BLL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.Customer
{
    public partial class CreateNewProject_Form : Form
    {
        public Abstraction.Interfaces.IProject MyProject { get; set; }
        BLL.Services.ProjectService ProjectService = new BLL.Services.ProjectService();
        private BLL.Services.CodeLanguageService codelanguageService;
        private List<ICodeLanguage> codelanguages;
        public Abstraction.Interfaces.ICodeLanguage Language { get; set; }
        


        public CreateNewProject_Form()
        {
            InitializeComponent();

            MyProject = new Project();

            codelanguageService = new BLL.Services.CodeLanguageService();
            codelanguages = codelanguageService.GetAllCodeLanguages();

            foreach (var codelanguage in codelanguages)
            {
                cb_projectRequierements.Items.Add(codelanguage.Language);
            }

            
        

    }



        private void RegisterProject()
        {
            bool canParseHourWage = int.TryParse(tb_projectHourWage.Text, out int hourWage);

            if (!canParseHourWage)
            {
                MessageBox.Show("Please only use numbers for the Project!", "Invalid Project!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MyProject.Name = tb_projectName.Text;
                MyProject.Description = tb_projectDescription.Text;
                MyProject.HourWage = hourWage;
                MyProject.StartDate = dtp_startDate.Value;
                MyProject.EndDate = dtp_endDate.Value;
                MyProject.Requirements = cb_projectRequierements.Text;



                ProjectService.AddProject(MyProject);
            }
        }


       
        private void btn_registerProject_Click(object sender, EventArgs e)
        {
            RegisterProject();
            this.Close();
        }

        private void CreateNewProject_Form_Load(object sender, EventArgs e)
        {
        }

        private void CreateNewProject_Form_Load_1(object sender, EventArgs e)
        {

        }
    }
}
