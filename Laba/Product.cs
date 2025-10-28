using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Product
{
    private string name;
    private int price;
    private int count;
    private string number;

    public Product(string name, int price,string number,int count)
    {
        this.name = name;
        this.price = price;
        this.number = number;
        this.count = count;
    }
    public string getName
    {
        get { return name; }
    }
    public int getPrice
    {
        get { return price; }
    }
    public int getCount
    {
        get { return count; }
    }
    public void setCount(int count)
    {
        this.count = count;
    }
    public string getNumber()
    {
        return number;
    }


}
