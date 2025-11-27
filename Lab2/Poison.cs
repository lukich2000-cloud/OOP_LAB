using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Poison : Things
    {
        public Poison(int Rarity, string Name, string Description, int Weight,int Duration,String Effect) : base(Rarity, Name, Description, Weight)
        {
            this.Duration = Duration;
            this.Effect = Effect;
        }

        public int Duration { get; protected set; }
        public String Effect {  get; protected set; }
        

        public override string getFullInfo()
        {
            return getMainInfo() + "\nЭффект - " + Effect + "\nВремя действия - " + Duration;
        }

        public override string use()
        {
            return "Вы выпили зелье " + Name + " и получили эффект - " + Effect + " на " + Duration + "минут";
        }
    }
}
