namespace CMS.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string fatherName { get; set;}

        public DateTime DOB { get; set; }

        public string Address { get; set;}

        public string Gendre { get; set; }

        public ICollection<StudentCourses> Categories { get; set; }
    }
}
