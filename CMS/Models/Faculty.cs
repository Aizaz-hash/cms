namespace CMS.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Qualification { get; set; }

        public string Designation { get;set; }

        public int NumberOfPublication { get;set; }

        public DateTime DOB { get; set; }

        public DateTime DateOfJoining { get; set;}
        public ICollection<StudentCourses> Categories { get; set; }



    }


}

