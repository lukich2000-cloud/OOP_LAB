using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class QuestItem : Things
    {
        public QuestItem(int Rarity, string Name, string Description, int Weight,String QuestName,bool IsImportant,bool IsCompleted) : base(Rarity, Name, Description, Weight)
        {
            this.QuestName = QuestName;
            this.IsImportant = IsImportant;
            this.IsCompleted = IsCompleted;
        }

        public String QuestName { get; protected set; }
        public bool IsImportant { get; protected set; }
        public bool IsCompleted { get; protected set; }
        public override string getFullInfo()
        {
            String Importance = "Не особо нужный";
            String Complece = "Не закончен";
            if (IsImportant)
            {
                Importance = "Очень важный";
            }
            if (IsCompleted)
            {
                Complece = "Закончен";
            }
            return getMainInfo() + "\nДля квеста - " + QuestName + "\nВажность - " + Importance + "\nКвест - " + Complece;
        }

        public override string use()
        {
            return "Вы использовали квестовый предмет" + Name + "и получили подсказку";
        }
    }
}
