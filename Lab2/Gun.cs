using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Gun : Things
    {
        public Gun(int Rarity, string Name, string Description, int Weight, int Damage) : base(Rarity, Name, Description, Weight)
        {
            this.Damage = Damage;
        }

        public int Damage { get; protected set; }
        

        public override string getFullInfo()
        {
           return getMainInfo() + "\nУрон - " + Damage;
        }

        public override string use()
        {
            return "Вы выстрелили из оружия(" + Name + ")" + "и нанесли " + Damage + " урона";
        }
    }
}
