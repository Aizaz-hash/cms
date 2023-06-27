namespace CMS.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int credtHours { get; set; }

        public bool HaveLab { get; set; }

        public string PreReq { get; set; }
        public ICollection<StudentCourses> studentCourses { get; set; }
        public ICollection<CoursesFaculty> coursesFaculties { get; set; }



    }
}
