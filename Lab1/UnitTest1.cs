namespace Tests.Lab1
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyCourseTest()
        {
            CourseManagment course = new CourseManagment();
            Boolean res = course.IsEmptyCourse();
            Assert.True(res);
        }
        [Fact]
        public void EmptyTeacherTest()
        {
            CourseManagment course = new CourseManagment();
            Boolean res = course.IsEmptyTeachers();
            Assert.False(res);
        }
        [Fact]
        public void getFIOTest()
        {
            People people = new Student("Mitya", "Luka", "Viktorovich", 19, "Russia", "K3242", 2, "FPIN");
            String FIO = people.getFIO();
            String res = "Luka" + " " + "Mitya" + " " + "Viktorovich";
            Assert.Equal(res, FIO);
        }
    }
}
