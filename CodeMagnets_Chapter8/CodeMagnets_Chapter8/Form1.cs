using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagnets_Chapter8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void printL(List<string> a)
        {
            string result = "";
            foreach (string element in a)
                result += "\n" + element;
            MessageBox.Show(result);
        }

            private void button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            a.RemoveAt(2);

            if (a.Contains("two"))
            {
                a.Add(twopointtwo);
            }

            if (a.Contains("three"))
            {
                a.Add("four");
            }

            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }
            printL(a);
        }
    }
}
