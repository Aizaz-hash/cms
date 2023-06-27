namespace CMS.Models
{
    public class CoursesFaculty
    {
        public int facultyId { get; set; }
        public int CourseId { get; set; }

        public Faculty faculty { get; set; }
        public Courses Courses { get; set; }
    }
}
