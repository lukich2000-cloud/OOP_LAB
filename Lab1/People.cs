using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class People
{
    private string name;
    private string surname;
    private string secondName;
    private int age;
    private String citizenship;

    public People(string name, string surname, string secondName, int age, string citizenship)
    {
        this.name = name;
        this.surname = surname;
        this.secondName = secondName;
        this.age = age;
        this.citizenship = citizenship;
    }
    public string getFIO()
    {
        return this.surname + " " + this.name + " " + this.secondName;
    }
    public abstract String GetFullInfo();
    public string getCitizenship()
    {
        return this.citizenship;
    }
    public int getAge() { 
        return this.age;
    }
}
