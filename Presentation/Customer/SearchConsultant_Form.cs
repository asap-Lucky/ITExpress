using Abstraction.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Customer
{
    public partial class SearchConsultant : Form
    {
        private BLL.Facader.ConsultantService ConsultantService;
        private List<IConsultant> DataGridConsultants { get; set; }
        public SearchConsultant()
        {
            InitializeComponent();
            IntializeDataGridView2();
            this.ConsultantService = new BLL.Facader.ConsultantService(new BLL.Services.ConsultantService(), new BLL.Services.CodeLanguageService(), new BLL.Services.EndtypeService());
            DataGridConsultants = new List<IConsultant>();
            dataGridView2.DataSource = this.ConsultantService.GetAllConsultants();

            BLL.Models.Consultant consultant = (BLL.Models.Consultant)this.ConsultantService.GetConsultant(1);
            string test = consultant.Language.Language;
        }

        //Search Button Functionality
        private void button1_Click(object sender, EventArgs e)
        {
            string seatchTeam = tb_projectRequierements.Text;

        }

        public void IntializeDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.DataPropertyName = "FirstName";
            firstNameColumn.HeaderText = "Firstname";
            dataGridView2.Columns.Add(firstNameColumn);

            DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.DataPropertyName = "LastName";
            lastNameColumn.HeaderText = "Lastname";
            dataGridView2.Columns.Add(lastNameColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "Language.Language";
            languageColumn.HeaderText = "Specialization";
            dataGridView2.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName= "Email";
            emailColumn.HeaderText = "Email";
            dataGridView2.Columns.Add(emailColumn);
        }
    }
}
