using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class InventoryManager
    {
        public Inventory inventory;
        public List<Things> things;
        public InventoryManager()
        {
            inventory = new Inventory();
            things = new List<Things>();
            things.Add(new Gun(
                Rarity: 1,
                Name: "Бластер X-10",
                Description: "Компактный энергетический пистолет",
                Weight: 2,
                Damage: 25
            ));

            things.Add(new Gun(
                Rarity: 2,
                Name: "Плазменная винтовка",
                Description: "Мощное оружие дальнего боя",
                Weight: 8,
                Damage: 65
            ));

            things.Add(new Poison(
                Rarity: 1,
                Name: "Зелье здоровья",
                Description: "Восстанавливает жизненные силы",
                Weight: 1,
                Duration: 10,
                Effect: "Регенерация"
            ));

            things.Add(new Poison(
                Rarity: 2,
                Name: "Эликсир силы",
                Description: "Увеличивает физическую мощь",
                Weight: 1,
                Duration: 5,
                Effect: "Усиление атаки"
            ));

            things.Add(new QuestItem(
                Rarity: 0,
                Name: "Древний артефакт",
                Description: "Таинственный предмет древней цивилизации",
                Weight: 3,
                QuestName: "Потерянные реликвии",
                IsImportant: true,
                IsCompleted: false
            ));

            things.Add(new QuestItem(
                Rarity: 1,
                Name: "Письмо капитана",
                Description: "Важное послание от капитана стражи",
                Weight: 1,
                QuestName: "Передача сообщения",
                IsImportant: false,
                IsCompleted: true
            ));

            things.Add(new Shiled(
                Rarity: 2,
                Name: "Щит стража",
                Description: "Прочный металлический щит",
                Weight: 12,
                Defend: 15
            ));

            things.Add(new Shiled(
                Rarity: 3,
                Name: "Энергетический барьер",
                Description: "Щит из чистой энергии",
                Weight: 3,
                Defend: 25
            ));
        }
        public void start()
        {
            Console.WriteLine("Вы попали в систему по управлению инвентарем");
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                PrintCases();
                string com = Console.ReadLine();
                switch (com) 
                {
                    case "1": inventory.PrintAllThings(); 
                        break;
                    case "2": takeItem();
                        break;
                    case "3": inventory.ThrowOutItem(); 
                        break;
                    case "4": inventory.UpgradeItem();
                        break;
                    case "5": inventory.useItem(); 
                        break;
                    default: Console.WriteLine("Нет такой команды");
                        break;
                }
            }
        }
        
        private void PrintCases()
        {
            Console.WriteLine("Вывести список предметов - 1");
            Console.WriteLine("Подобрать предмет - 2");
            Console.WriteLine("Выкинуть предмет - 3");
            Console.WriteLine("Улучшить предмет - 4");
            Console.WriteLine("Использовать предмет - 5");
        }
        private void takeItem()
        {
            if(things.Count == 0)
            {
                Console.WriteLine("Нет предметов для поднятия");
                return;
            }
            inventory.addItem(things[0]);
            Console.WriteLine("Добавлен новый предмет в инвентарь - " + things[0].Name);
            things.RemoveAt(0);
        }
    }
}
