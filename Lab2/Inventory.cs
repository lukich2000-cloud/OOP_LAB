using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Inventory : IInventory
    {
        List<Things> Items { get; set; }
        public void addItem(Things things) {  Items.Add(things); }
        public Inventory()
        {
            Items = new List<Things>();
        }
        public void PrintAllThings()
        {
            if (Items.Count == 0) 
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            Console.WriteLine("Список предметов:");
            foreach (var item in Items)
            { 
                Console.WriteLine(item.getFullInfo());
                Console.WriteLine("-------------------------------");
            }
        }
        private void printItemNames()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            Console.WriteLine("Список предметов:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("-------------------------------");
            }
        }
        private void printItemNamesAndRarity()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            Console.WriteLine("Список предметов:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name + " - " + item.GetRarityToString());
                Console.WriteLine("-------------------------------");
            }
        }

        public void TakeItem(Things item)
        {
            Items.Add(item);
            Console.WriteLine("Добавлен новый предмет в инвентарь - " + item.Name);
        }

        public void ThrowOutItem()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            printItemNames();
            Console.WriteLine("Выберите имя предмета, чтобы выкинуть:");
            string name = Console.ReadLine();
            foreach (var item in Items)
            {
                if(item.Name == name)
                {
                    Items.Remove(item);
                    Console.WriteLine("Вы выкинули предмет - " + item.Name);
                    return;
                }
            }
            Console.WriteLine("Нет такого имени предмета");
            
        }

        public void UpgradeItem()
        {
            if (Items.Count < 1)
            {
                Console.WriteLine("Инвентарь не достаточно полон");
                return;
            }
            printItemNamesAndRarity();
            Console.WriteLine("Выберите имя предмета, чтобы улучшить:");
            string name1 = Console.ReadLine();
            Console.WriteLine("И еще одно имя предмета такой же редкости, чтобы улучшить:");
            string name2 = Console.ReadLine();
            if(name1 == name2)
            {
                Console.WriteLine("Нельзя выбирать одинаковые предметы");
                return;
            }
            Things things1 = null;
            Things things2 = null; ;
            foreach (var item in Items)
            {
                if (item.Name == name1) 
                {
                    things1 = item;
                }
            }
            foreach (var item in Items)
            {
                if (item.Name == name2) 
                {
                    things2 = item;
                }
            }
            if (things1 != null && things2 != null && things1.Rarity == things2.Rarity)
            {
                things1.Rarity++;
                Console.WriteLine("Улучшен предмет - " + things1.Name);
                Items.Remove(things2);
                return;
            }
            Console.WriteLine("Нельзя улучшить такие предметы");

        }
        public void useItem()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            printItemNames();
            Console.WriteLine("Выберите имя предмета, чтобы использовать:");
            string name = Console.ReadLine();
            foreach (var item in Items)
            {
                if (item.Name == name)
                {
                    Console.WriteLine(item.use());
                    return;
                }
            }
            Console.WriteLine("Нет такого имени предмета");
        }
    }
}
