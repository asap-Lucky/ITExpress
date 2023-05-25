using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.All
{
    public partial class RecieveMessage_Form : Form
    {
        Abstraction.Interfaces.IMessage selectedMessage;

        BLL.Services.MessageService MessageService;

        public RecieveMessage_Form(IMessage selectedMessage)
        {
            InitializeComponent();
            this.selectedMessage = selectedMessage;
            MessageService = new BLL.Services.MessageService();
        }
    }
}
