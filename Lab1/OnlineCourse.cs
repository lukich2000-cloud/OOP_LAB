using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OnlineCourse : Courses
{
    String platform;

    public OnlineCourse(string Name, string Description, int DurationHours, int credit_units, string type_of_control, string platform) : base(Name, Description, DurationHours, credit_units, type_of_control)
    {
        this.type = "Online";
        this.platform = platform;
    }

    public override void PrintFullCourseInfo()
    {
        GetMainCourseInfo();
        Console.WriteLine("Платформа курса - " + platform);
        PrintListOfStudents();
    }
}
