using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : People
{
    private String group;
    private int cours;
    private String Fakultet;
    public Student(string name, string surname, string secondName,int age,String citizenship,String group,int cours,String Fakultet) : base(name, surname, secondName,age, citizenship)
    {
        this.group = group;
        this.cours = cours;
        this.Fakultet = Fakultet;
    }

    public override string GetFullInfo()
    {
        return "Студент(" + getFIO() + "):\nграждансто - " + getCitizenship() + "\nвозраст - " + getAge() + "\nгруппа - " + group + "\nкурс - " + cours + "\nфакультет - " + Fakultet; 
    }
}
