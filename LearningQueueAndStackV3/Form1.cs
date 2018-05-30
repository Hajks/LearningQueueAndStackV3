using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningQueueAndStackV3
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();

        }

        private void RedrawList()
        {
            queueListBox.Items.Clear();
            int number = queueListBox.Items.Count + 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                queueListBox.Items.Add("\n\r" + number + ". " + lumberjack.Name);
            }
        }

        private void addLumberjackButton_Click(object sender, EventArgs e)
        {

            breakfastLine.Enqueue(new Lumberjack(lumberjackTextbox.Text));
            int number = queueListBox.Items.Count +1 ;
            queueListBox.Items.Add("\n\r" + number +". "+lumberjackTextbox.Text);
            lumberjackTextbox.Text = "";
    
        }

        private void addPancakeButton_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (soggy.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (browned.Checked == true)
                food = Flapjack.Rumianego;
            else
                food = Flapjack.Bananowego;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);                
            lumberjackEating.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
        }

        private void nextLumberjackButton_Click(object sender, EventArgs e)
        {
            if (queueListBox.Items.Count <= 0)
                MessageBox.Show("Nie ma nikogo w kolejce");
            else
            { 
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.EatFlapjacks();
            breakfastLine.Dequeue();
            RedrawList();
            lumberjackEating.Text = "";
            if (String.IsNullOrEmpty(queueListBox.Text)) return;
            }
        }
    }
}
