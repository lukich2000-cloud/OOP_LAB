using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Courses : ICourse
{
    string Name;
    string Description;
    int DurationHours;
    List<Student> students;
    int credit_units;
    String type_of_control;
    List<Teacher> teachers;
    protected String type {  get; set; }
    public List<Teacher> GetTeachers()
    { return teachers; }
    public Courses(string Name, string Description, int DurationHours, int credit_units, String type_of_control) 
    {
        Student student = new Student("Doma", "Luk", "Viktorovich", 19, "Russia", "K3242", 2, "FPIKT");
        Student student3 = new Student("Alex", "Lukoshnikov", "Viktorovich", 19, "Russia", "K3242", 2, "FPIKT");
        Student student1 = new Student("Dama", "Lukoshnikov", "Viktorovich", 19, "Russia", "K3242", 2, "FPIKT");
        Student student2 = new Student("Amid", "Lukoshnikov", "Viktorovich", 19, "Russia", "K3242", 2, "FPIKT");
        this.Name = Name;
        this.Description = Description;
        this.DurationHours = DurationHours;
        this.credit_units = credit_units;
        this.type_of_control = type_of_control;
        this.students = new List<Student> { student,student1,student2,student3};
        this.teachers = new List<Teacher>();
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine("Добавлен новый студент(" + student.getFIO() + ") - на курс: " + Name);
    }
    public void RemoveTeacher(Teacher teacher)
    {
        teachers.Remove(teacher);
    }

    public void GetMainCourseInfo()
    {
        Console.WriteLine("Основная Информация о курсе: \nТип - " + type + "\nНазвание - " + Name + "\nОписание - " +  Description + "\nКоличество учебных часов - " + DurationHours + "\nКоличество зачетных единиц - " + credit_units + "\nТип контроля - " + type_of_control);
    }

    public void RemoveStudent(Student student)
    {
        students.Remove(student);
        Console.WriteLine("Удален студент(" + student.getFIO() + ") - с курса: " + Name);
    }

    public void PrintListOfStudents()
    {
        Console.WriteLine("Список студентов курса - " + getName() + ":");
        Console.WriteLine("-------------------------");
        foreach (Student student in students) 
        {
            Console.WriteLine(student.getFIO());
        }
        Console.WriteLine("-------------------------");
    }
    public void PrintListOfTeachers()
    {
        Console.WriteLine("Список учителей, ведущих курс - " + getName() + ":");
        Console.WriteLine("-------------------------");
        foreach (Teacher teacher in teachers)
        {
            Console.WriteLine(teacher.getFIO());
        }
        Console.WriteLine("-------------------------");
    }
    public abstract void PrintFullCourseInfo();
    public String getName()
    {
        return Name;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
        teacher.addCourse(this);
    }
    
}