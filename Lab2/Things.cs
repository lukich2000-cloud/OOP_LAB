using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Things
    {
        public Things(int Rarity,string Name,string Description,int Weight)
        {
            this.Rarity = Rarity;
            this.Name = Name;
            this.Description = Description;
            this.Weight = Weight;
        }
        public int Rarity { get; set; }
        public String Name { get; protected set; }
        public String Description { get; protected set; }
        
        public int Weight { get; protected set; }
        public String getMainInfo()
        {
            return "Информация о предмете:\nНазвание - " + Name + "\nОписание - " + Description + "\nРедкость - " + GetRarityToString() + "\nВес - " + Weight;
        }
        public abstract String getFullInfo();
        public abstract String use();
        public String GetRarityToString()
        {
            switch (Rarity)
            {
                case 0:
                    return "Обычный";
                    break;
                case 1:
                    return "Необычный";
                    break;
                case 2:
                    return "Редкий";
                    break;
                case 3:
                    return "Эпический";
                    break;
                default:
                    return "Легендарный";
                    break;
            }
        }
    }
}
