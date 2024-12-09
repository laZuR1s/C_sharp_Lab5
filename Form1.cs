using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить новый файл";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, textBox1.Text);
                    textBox1.Text = File.ReadAllText(currentFilePath);

                }
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Открыть файл";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(currentFilePath);

                }
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox1.Text);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Сохранить как";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, textBox1.Text);
                }
            }
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string processedText = RemoveEmptyLines(textBox1.Text);
            textBox2.Text = processedText;
        }

        private string RemoveEmptyLines(string input)
        {
            string[] lines = input.Split(new[] { "\n" }, StringSplitOptions.None); 
            List<string> filteredLines = new List<string>(); 

            for (int i = 0; i < lines.Length; i++)
            {
                bool isEmpty = true;

                foreach (char c in lines[i])
                {
                    if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
                    {
                        isEmpty = false; 
                        break;
                    }
                }
                if (!isEmpty)
                {
                    filteredLines.Add(lines[i]);
                }
            }
            return string.Join("\n", filteredLines);
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void saveModifiedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Сохранить как";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveFileDialog.FileName;
                        File.WriteAllText(currentFilePath, textBox2.Text);
                    }
                }
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox2.Text);
            }
        }
    }
}
