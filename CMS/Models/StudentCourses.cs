namespace CMS.Models
{
    public class StudentCourses
    {
        public int studentId { get; set; }
        public int CourseId { get; set; }

        public Students Students { get; set; }
        public Courses Courses { get; set; }
    }
}
