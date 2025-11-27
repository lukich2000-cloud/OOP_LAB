using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class CourseManagment
{
    List<Courses> courses;
    List<Teacher> teachers;
    
    
    public CourseManagment()
    {
        Teacher teacher = new Teacher("Alena", "Tolikova", "Valerevna", 45, "Russia", 24);
        Teacher teacher1 = new Teacher("Lena", "Temnikova", "Valerevna", 45, "Russia", 24);
        Teacher teacher2 = new Teacher("Elena", "Larisa", "Valerevna", 45, "Russia", 24);
        Teacher teacher3 = new Teacher("Elena", "Temnikova", "Viktorvna", 45, "Russia", 24);
        courses = new List<Courses>();
        teachers = new List<Teacher> { teacher,teacher1,teacher2,teacher3};
    }
    public void start()
    {
        Console.WriteLine("Вы попали в систему по управлению курсами и преподавателями");
        while (true)
        {
            pazd();
            printCommands();
            String command = Console.ReadLine();
            switch (command) 
            {
                case "1":courses.Add(CreateCourse());
                    break;
                case "2":RemoveCourseByName();
                    break;
                case "3": setTeacherOnCourse(); 
                    break;
                case "4":getCourseStudents();
                    break;
                case "5": getCoursesByTeacher();
                    break;
                case "6":PrintAllCoursesName(); 
                    break;
                case "7":PrintAllTeachers();
                    break;
                default:Console.WriteLine("Нет такой команды");
                    break;

            }
        }
    }
    public Boolean IsEmptyCourse() 
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("Нет доступных курсов");
            return true;
        }
        else
        {
            return false;
        }
    }
    public Boolean IsEmptyTeachers()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("Нет доступных учителей");
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private void RemoveCourseByName()
    {
        if (IsEmptyCourse())
        {
            return;
        }
        PrintAllCoursesName();
        Console.WriteLine("Напишите имя курса, который хотите удалить:");
        String name = Console.ReadLine();
        foreach (Courses course in courses) 
        { 
            if(course.getName() == name)
            {
                courses.Remove(course);
                foreach(Teacher teacher in course.GetTeachers())
                {
                    teacher.RemoveCourse(course);
                }
                Console.WriteLine("Курс - " + course.getName() + " удален");
                return;
            }
        }
        Console.WriteLine("Нет такого имени курса");
    }
    public void PrintAllCoursesName()
    {
        if (IsEmptyCourse())
        {
            return;
        }
        Console.WriteLine("Список доступных курсов:");
        foreach (Courses course in courses)
        {
            Console.WriteLine(course.getName());
        }
    }
    public void PrintAllTeachers()
    {
        if (IsEmptyTeachers())
        {
            return;
        }
        Console.WriteLine("Список всех учителей:");
        pazd();
        foreach(Teacher teacher in teachers)
        {
            Console.WriteLine(teacher.getFIO());
        }
        pazd();
    }
    private void setTeacherOnCourse()
    {
        if (IsEmptyTeachers() || IsEmptyCourse()) 
        {
            return;
        }
        Boolean f = false;
        PrintAllTeachers();
        Console.WriteLine("Напишите ФИО учителя которого хотите добавить на курс:");
        String FIO = Console.ReadLine();
        Teacher teacher1 = null;
        foreach(Teacher teacher in teachers)
        {
            if(teacher.getFIO() == FIO)
            {
                f = true;
                teacher1 = teacher;
                break;
            }
        }
        if (!f)
        {
            Console.WriteLine("Нет такого учителя:");
            return;
        }
        PrintAllCoursesName();
        Console.WriteLine("Напишите имя курса, на которое вы хотите назначить преподавателя:");
        String courseName = Console.ReadLine();
        foreach (Courses courses in courses)
        {
            if (courses.getName() == courseName)
            {
                courses.AddTeacher(teacher1);
                Console.WriteLine("Добавлен новый учитель на курс - " + courses.getName());
                courses.PrintListOfTeachers();
                return;
            }
        }
        Console.WriteLine("Нет такого курса");
    }
    private void getCoursesByTeacher()
    {
        if (IsEmptyTeachers())
        {
            return;
        }
        PrintAllTeachers();
        Console.WriteLine("Напишите ФИО учителя, у которого хотите получить список всех курсов:");
        String FIO = Console.ReadLine();
        foreach(Teacher teacher in teachers)
        {
            if(teacher.getFIO()== FIO)
            {
                teacher.PrintCourses();
                return;
            }
        }
        Console.WriteLine("Нет такого учителя");
    }
    private void printCommands()
    {
        while (true)
        {
            Console.WriteLine("Список доступных команд:");
            pazd();
            Console.WriteLine("Добавить курс - 1");
            Console.WriteLine("Удалить курс - 2");
            Console.WriteLine("Назначить преподавателя на курс - 3");
            Console.WriteLine("Получить информацию о студентах, записанных на определнный курс - 4");
            Console.WriteLine("Получить все курсы, которые ведет конкретный преподаватель - 5");
            Console.WriteLine("Вывести список всех курсов - 6");
            Console.WriteLine("Вывести список всех учителей - 7");
            pazd();
            Console.WriteLine("Выберите команду и напишите ее номер:");
            return;
        }
        
    }
    private void getCourseStudents()
    {
        if (IsEmptyCourse())
        {
            return;
        }
        PrintAllCoursesName();
        Console.WriteLine("Введите имя курса, чтобы получить информацию о студентах:");
        String name = Console.ReadLine();
        foreach (Courses courses in courses)
        {
            if (courses.getName() == name)
            {
                courses.PrintListOfStudents();
                return;
            }
        }
        Console.WriteLine("Нет такого имени курса");
    }
    private Courses CreateCourse()
    {
        Console.WriteLine("Идет создание курса:");
        Console.WriteLine("Имя курса:");
        String name = Console.ReadLine();
        Console.WriteLine("Небольшое описание курса:");
        String description = Console.ReadLine();
        String DurationHours;
        while (true)
        {
            Console.WriteLine("Количество учебных часов:");
            DurationHours = Console.ReadLine();
            if (DurationHours.All(char.IsDigit))
            {
                break;
            }
            else
            {
                Console.WriteLine("Должны быть только цифры");
            }
        }
        String credit_units;
        while (true)
        {
            Console.WriteLine("Количество зачетных единиц:");
            credit_units = Console.ReadLine();
            if (credit_units.All(char.IsDigit))
            {
                break;
            }
            else
            {
                Console.WriteLine("Должны быть только цифры");
            }
        }
        String type_of_control;
        while (true)
        {
            Console.WriteLine("Тип контроля:");
            Console.WriteLine("Экзамен - 1");
            Console.WriteLine("Зачет - 2");
            type_of_control = Console.ReadLine();
            if(type_of_control == "1")
            {
                type_of_control = "Экзамен";
                break;
            }else if(type_of_control == "2")
            {
                type_of_control = "Зачет";
                break;
            }
            else
            {
                Console.WriteLine("Нет такого типа контроля");
            }
        }
        while (true)
        {
            Console.WriteLine("Тип курса:");
            Console.WriteLine("Онлайн курс - 1");
            Console.WriteLine("Офлайн курс - 2");
            String decision = Console.ReadLine();
            if ((decision == "1"))
            {
                Console.WriteLine("Платформа для изучения курса:");
                String platform = Console.ReadLine();
                Console.WriteLine("Вы создали новый онлайн курс: " + name);
                return new OnlineCourse(name, description, int.Parse(DurationHours), int.Parse(credit_units), type_of_control, platform);
            }
            else if ((decision == "2")) 
            {
                Console.WriteLine("Напишите адрес корпуса, где будут идти занятия:");
                String Location = Console.ReadLine();
                String maxStudents;
                while (true)
                {
                    Console.WriteLine("Максимальное количество студентов на курсе:");
                    maxStudents = Console.ReadLine();
                    if (maxStudents.All(char.IsDigit))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Должно быть только число");
                    }
                }
                Console.WriteLine("Вы создали новый офлайн курс: " + name);
                return new OfflineCourse(name, description, int.Parse(DurationHours), int.Parse(credit_units), type_of_control, Location, int.Parse(maxStudents));
            }
            else
            {
                Console.WriteLine("Нет такого типа курса:");
            }
        }
        
    }
    private void pazd()
    {
        Console.WriteLine("-------------------------------------------");
    }

}
