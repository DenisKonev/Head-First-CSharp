using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastForLumberjacks
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
            RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text))
            {
                breakfastLine.Enqueue(new Lumberjack(name.Text));
                name.Clear();
                RedrawList();
            }
            else
                MessageBox.Show("Please enter a lumberjack's name");
        }

        private void RedrawList()
        {
            //Update breakfastLine
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if(breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
                crispy.Checked = true;
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if(breakfastLine.Count == 0) 
                return;
            Flapjack food;
            if(crispy.Checked == true)
                food = Flapjack.Banana;
            else if(soggy.Checked == true)
                food = Flapjack.Soggy;
            else if(browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Crispy;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }
    }
}
