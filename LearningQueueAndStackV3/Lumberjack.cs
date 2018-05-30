using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningQueueAndStackV3
{
    public enum Flapjack
    {
        Chrupkiego,
        Wilgotnego,
        Rumianego,
        Bananowego,

    }
    public class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack <Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count(); } }
        public void TakeFlapjacks (Flapjack food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(food);
            }

        }
        public void EatFlapjacks()
        {
            string ate = "";
            while (meal.Count > 0)
            {
                ate += name + " zjadł " + meal.Pop() + "\n";
            }
            if (meal.Count == 0)
            {
                MessageBox.Show(name + " zmienił zdanie i nie ma ochoty na naleśniki");
           }
            MessageBox.Show(name + " je naleśniki" + "\n\r" + ate);
        }
    }
}
