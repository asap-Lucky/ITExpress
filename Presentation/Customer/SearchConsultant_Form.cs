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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Presentation.Customer
{
    public partial class SearchConsultant : Form
    {
        private BLL.Services.ConsultantService ConsultantService;
        private List<IConsultant> DefaultConsultantList { get; set; }
        private List<IConsultant> SortedConsultantsList { get; set; }
        public SearchConsultant()
        {
            InitializeComponent();
            IntializeDataGridView2();
            this.ConsultantService = new BLL.Services.ConsultantService();
            DefaultConsultantList = this.ConsultantService.GetAllConsultants();
            dataGridView2.DataSource = DefaultConsultantList;
        }

        //Search Button Functionality
        private void button1_Click(object sender, EventArgs e)
        {             
            if(tb_projectRequierements.Text == string.Empty) 
            {
                dataGridView2.DataSource = DefaultConsultantList;
            }
            else
            {
                dataGridView2.DataSource = ConsultantService.CodeLangaugeBinarySearch(DefaultConsultantList, tb_projectRequierements.Text);
            }
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
            languageColumn.DataPropertyName = "GetLanguage";
            languageColumn.HeaderText = "Specialization";
            dataGridView2.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetEndType";
            endTypeColumn.HeaderText = "EndType";
            dataGridView2.Columns.Add(endTypeColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName= "Email";
            emailColumn.HeaderText = "Email";
            dataGridView2.Columns.Add(emailColumn);
        }
    }
}
