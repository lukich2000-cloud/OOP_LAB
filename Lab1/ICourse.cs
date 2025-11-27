using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICourse
{
    void AddStudent(Student student);
    void RemoveStudent(Student student);
    void GetMainCourseInfo();
    void PrintListOfStudents();    
}
