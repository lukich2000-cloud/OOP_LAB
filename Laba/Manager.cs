using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manager
{
    private Vending vending;
    
    public Manager(Vending vending)
    {
        this.vending = vending;
    }
    public void start()
    {
        while (true)
        {
            Console.WriteLine("--------------------------------------------------------------");
            options();
            string command = Console.ReadLine();
            switch (command) 
            {
                case "1":
                    System.Console.WriteLine("Список продуктов их количества и стоимости:"); 
                    vending.GetListOfProducts();
                    break;
                case "2": vending.Addmonety();
                    break;
                case "3": Console.WriteLine("Текущий баланс = " + vending.getDeposit());
                    break;
                case "4": vending.BuyProduct(); 
                    break;
                case "5": vending.exit();
                    break;
                case "6": vending.admin();
                    break;
                default: Console.WriteLine("Неверный номер команды, нужна только цифра");
                    break;
            }
        }

    }
    private void options()
    {
        Console.WriteLine("Посмотреть список доступных товаров с их ценами и количеством - 1");
        Console.WriteLine("Вставить монеты разных номиналов(1,2,5,10) - 2");
        Console.WriteLine("Посмотреть текущий баланс - 3");
        Console.WriteLine("Купить товар - 4");
        Console.WriteLine("Закончить покупки(отойти от вендинга) - 5");
        Console.WriteLine("Войти в режим администратора  - 6");
        Console.WriteLine("Выберите опцию, нажав только цифру:");
    }
    
}
