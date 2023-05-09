﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace UI.Consultant
{
    public partial class SignUpConsultant_Form : Form
    {
        public Abstraction.Interfaces.IConsultant MyConsultant { get; set; }

        BLL.Services.ConsultantService ConsultantService = new BLL.Services.ConsultantService();

        public SignUpConsultant_Form()
        {
            InitializeComponent();
            MyConsultant = new BLL.Models.Consultant();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterConsultant()
        {

        }

        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterConsultant();
        }
    }
}
