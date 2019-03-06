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

namespace MSK_Copier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            var completedList = new List<string>();
            var inCompletedList = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var sourceFile = row.Cells[0].Value.ToString();
                foreach (DataGridViewRow row2 in dataGridView2.Rows)
                {
                    var destinationFolder = row.Cells[0].Value.ToString();
                    if (File.Exists(sourceFile))
                    {
                        if (File.Exists($@"{destinationFolder}\{Path.GetFileName(sourceFile)}"))
                        {
                            var dialogResult = new Message().ShowDialog(); 
                        }
                        File.Copy(sourceFile, $@"{destinationFolder}\{Path.GetFileName(sourceFile)}",true);
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
