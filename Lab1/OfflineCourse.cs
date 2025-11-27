using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OfflineCourse : Courses
{
    String Location;
    int maxStudents;
    public OfflineCourse(string Name, string Description, int DurationHours, int credit_units, string type_of_control,String Location,int maxStudents) : base(Name, Description, DurationHours, credit_units, type_of_control)
    {
        this.type = "Offline";
        this.Location = Location;
        this.maxStudents = maxStudents;
    }

    public override void PrintFullCourseInfo()
    {
       GetMainCourseInfo();
       Console.WriteLine("Локация - " + Location + "\nМаксимальное количество студентов - " + maxStudents);
       PrintListOfStudents(); 
    }
}
