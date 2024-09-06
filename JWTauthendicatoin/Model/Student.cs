using System.ComponentModel.DataAnnotations;

namespace JWTauthendicatoin.Model
{
    public class Student
    {
        [Key]
        public string? StudentName{ get; set; }
        public int? StudentId { get; set; }

        public string? SchoolName { get; set; }
           
    }
}
