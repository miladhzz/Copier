using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            var operation = Operation.Yes;
            var completedList = new List<string>();
            var inCompletedList = new List<string>();
            for (var i=0; i<dataGridView1.RowCount -1 ; i++)
            {
                var row = dataGridView1.Rows[i];
                var sourceFile = row.Cells[0].Value?.ToString();
                for (var j = 0; j < dataGridView2.RowCount - 1; j++)
                {
                    var row2 = dataGridView2.Rows[j];
                    var destinationFolder = row2.Cells[0].Value?.ToString();
                    if (File.Exists(sourceFile))
                    {
                        if (File.Exists($@"{destinationFolder}\{Path.GetFileName(sourceFile)}"))
                        {
                            if (!(operation == Operation.YesToAll || operation == Operation.NoToAll))
                            {
                                var message = new Message($@"File {destinationFolder}\{Path.GetFileName(sourceFile)} is already exists, do you want to replace it?");
                                message.ShowDialog();
                                switch (message.Operation)
                                {
                                    case Operation.Yes:
                                        operation = Operation.Yes;
                                        break;
                                    case Operation.YesToAll:
                                        operation = Operation.YesToAll;
                                        break;
                                    case Operation.No:
                                        operation = Operation.No;
                                        break;
                                    case Operation.NoToAll:
                                        operation = Operation.NoToAll;
                                        break;
                                    case Operation.Cancel:
                                        operation = Operation.Cancel;
                                        break;
                                }
                            }
                        }
                        if (operation == Operation.Yes || operation == Operation.YesToAll)
                        {
                            File.Copy(sourceFile, $@"{destinationFolder}\{Path.GetFileName(sourceFile)}", true);
                            completedList.Add(sourceFile);
                        }
                    }
                    else
                    {
                        inCompletedList.Add(sourceFile);
                    }
                }
            }
        }
    }
}
