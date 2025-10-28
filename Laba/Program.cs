using System;

class Program
{
    static void Main(string[] args)
    {
        Vending vending = new Vending();
        Manager manager = new Manager(vending);
        manager.start();
    }
}