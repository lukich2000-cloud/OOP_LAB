using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vending
{
    private int deposit;
    List<Product> products = new List<Product>();
    private string parol = "dim";
    private int pribul;
    public Vending()
    {
        this.deposit = 0;
    }

    public void AddProducts(List<Product> producty)
    {
        if (products == null)
        {
            products = producty;
            Console.WriteLine("Добавлены новые продукты");
            return;
        }
        foreach (var product in producty)
        {
            foreach (var item in products)
            {
                if (product.getName == item.getName)
                {
                    item.setCount(item.getCount + product.getCount);
                }
            }
            products.Add(product);
        }
        Console.WriteLine("Добавлены новые продукты");
    }
    public void GetListOfProducts()
    {
        if (!products.Any())
        {
            Console.WriteLine("Нет продуктов");
            return;
        }
        foreach(var product in products)
        {
            System.Console.WriteLine(product.getName + "( " + product.getCount + "шт.) - " + product.getPrice);
        }
    }
    public void Adddeposit(int summa)
    {
        this.deposit += summa;
        Console.WriteLine("Ваш депозит = " + deposit);
    }
    public void Addmonety()
    {
        List<string> monety = new List<string>
        {
            "1","2","5","10"
        };
        bool f = true;
        while (f = true)
        {
            Console.WriteLine("Вставить монету - 1");
            Console.WriteLine("Закончить вставку монет - 2");
            Console.WriteLine("Выбырите опцию:");
            string com = Console.ReadLine();
            if (com == "1")
            {
                Console.WriteLine("Вставьте монету, равную номиналу 1,2,5,10 рублям:");
                string mon = Console.ReadLine();
                if (monety.Contains(mon))
                {
                    Adddeposit(int.Parse(mon));
                }
                else
                {
                    Console.WriteLine("Нет такого типа монет");
                }
            }
            else if (com == "2") 
            {
                return;
            }
            else
            {
                Console.WriteLine("Нет такой команды");
            }
        }
    }
    public void BuyProduct()
    {
        if (products == null)
        {
            Console.WriteLine("Нет продуктов для покупки");
            return;
        }
        foreach (var product in products)
        {
            Console.WriteLine(product.getName + "(" + product.getPrice + "р.)" + " - " + product.getNumber());

        }
        Console.WriteLine("Выберите продукт и напишите его номер, который идет после тире:");
        string com = Console.ReadLine();
        foreach (var product in products)
        {
            if (product.getNumber() == com)
            {
                if(deposit > product.getPrice)
                {
                    Console.WriteLine("Вы приобрели " +  product.getName);
                    Console.WriteLine("Заберите сдачу - " +  Convert.ToString(deposit - product.getPrice));
                    pribul += product.getPrice;
                    deposit = 0;
                    product.setCount(product.getCount - 1);
                    if (product.getCount <= 0)
                    {
                        products.Remove(product);
                    }
                    return;
                } else if (deposit == product.getPrice)
                {
                    Console.WriteLine("Вы приобрели " + product.getName);
                    pribul += product.getPrice;
                    deposit = 0;
                    product.setCount(product.getCount - 1);
                    if (product.getCount <= 0)
                    {
                        products.Remove(product);
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Недостаточно средств");
                    return;
                }
            }
        }
        Console.WriteLine("Нет такого номера  товара");
    }
    public void exit()
    {
        if (deposit > 0)
        {
            Console.WriteLine("Заберите неиспользованные средства - " + deposit);
        }
        Console.WriteLine("До свидания!");
        Environment.Exit(0);
    }
    public void admin()
    {
        Console.WriteLine("Чтобы зайти в режим администратора, нужно ввести пароль:");
        string paroly = Console.ReadLine();
        if (paroly == parol)
        {
            while (true)
            {
                Console.WriteLine("Вы в режиме администратора");
                Console.WriteLine("Добавить продукт - 1");
                Console.WriteLine("Собрать средства - 2");
                Console.WriteLine("Выйти из режима администартора - 3");
                string com = Console.ReadLine();
                switch (com)
                {
                    case "1": addProduct();
                        break;
                    case "2": getPribul(); 
                        break;
                    case "3": return;
                    default: Console.WriteLine("Неверная команда");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Неправильный пароль");
        }
    }
    public void addProduct()
    {
        string pric = "0";
        string coun = "0";
        Console.WriteLine("Название продукта:");
        string nam = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("Цена:");
            pric = Console.ReadLine();
            if (!pric.All(char.IsDigit))
            {
                Console.WriteLine("Цена должна быть числом");
            }
            else
            {
                break;
            }
        }
        while (true)
        {
            Console.WriteLine("Количество:");
            coun = Console.ReadLine();
            if (!coun.All(char.IsDigit))
            {
                Console.WriteLine("Количество должн0 быть числом");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Номер товара:");
        string numb = Console.ReadLine();
        Product product = new Product(nam,int.Parse(pric),numb,int.Parse(coun));
        products.Add(product);
        Console.WriteLine("Добавлен новый продукт - " + product.getName);
    }
    public void getPribul()
    {
        if (pribul == 0)
        {
            Console.WriteLine("К сожалению, прибыли нет");
        }
        else
        {
            Console.WriteLine("Вы собрали - " + pribul);
            pribul = 0;
        }
    }
    public int getDeposit()
    {
        return deposit;
    }
}
