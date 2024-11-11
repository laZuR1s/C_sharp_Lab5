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

namespace C_sharp_Lab5
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void NewFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentFilePath = string.Empty;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(currentFilePath);

                }
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                SaveToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox1.Text); 
            }
        }
    }
}
