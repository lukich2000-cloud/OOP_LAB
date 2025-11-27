using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Teacher : People
{
    private int yearsOfExperience;
    List<Courses> Courses;
    public List<Courses> GetCourses() 
    { return Courses; }

    public Teacher(String name,String surname,String secondName,int age,String citizenship, int yearsOfExperience) : base(name, surname, secondName,age,citizenship)
    {
        this.yearsOfExperience = yearsOfExperience;
        this.Courses = new List<Courses>();
    }
    public void addCourse(Courses course)
    {
        Courses.Add(course);
    }
    public void RemoveCourse(Courses course)
    {
        Courses.Remove(course);
    }
    

    public override string GetFullInfo()
    {
        return "Преподаватель(" + getFIO() + "): \nвозраст - " + getAge() + "\nгражданство - " + getCitizenship() + "\nстаж работы - " + yearsOfExperience;
    }
    public void PrintCourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine("Преподаватель  - " + getFIO() + " не ведет никаких курсов");
            return;
        }
        Console.WriteLine("Курсы которые ведет - " + getFIO() + ":");
        foreach (var courses in Courses)
        {
            Console.WriteLine(courses.getName());
        }
    }
}
