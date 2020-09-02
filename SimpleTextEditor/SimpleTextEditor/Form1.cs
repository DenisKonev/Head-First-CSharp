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

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
            TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
            styles[1].SizeType = SizeType.Absolute;
            styles[1].Height = 80;
            openFileDialog1.InitialDirectory = @"C:\Temp";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = @"C:\Temp";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
