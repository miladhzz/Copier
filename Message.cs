using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copier
{
    public partial class Message : Form
    {
        private string _message = "";
        public Message(string message)
        {
            InitializeComponent();
            _message = message;
            Operation = Operation.Cancel;
        }
        public Operation Operation;
        private void BtnYes_Click(object sender, EventArgs e)
        {
            Operation = Operation.Yes;
            Close();
        }

        private void BtnYestToAll_Click(object sender, EventArgs e)
        {
            Operation = Operation.YesToAll;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Operation = Operation.No;
            Close();
        }

        private void BtnNoToAll_Click(object sender, EventArgs e)
        {
            Operation = Operation.NoToAll;
            Close();
        }

        private void BtnCancell_Click(object sender, EventArgs e)
        {
            Operation = Operation.NoToAll;
            Close();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            label1.Text = _message;
        }
    }
}
