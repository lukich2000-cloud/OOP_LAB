using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public class Shiled : Things
    {
        public Shiled(int Rarity, string Name, string Description, int Weight,int Defend) : base(Rarity, Name, Description, Weight)
        {
            this.Defend = Defend;
        }

        public int Defend {  get; protected set; }
        public override string getFullInfo()
        {
            return getMainInfo() + "\nЗащита(уровень) - " + Defend;
        }

        public override string use()
        {
            return "Вы одели " + Name + " - ваш уровень защиты вырос на " + Defend;
        }
    }
}
