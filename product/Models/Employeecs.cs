using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    public class Employeecs
    {
        [Key]
        public int empid {  get; set; }
        public string ?empname {  get; set; }
         
        public string ?depname {  get; set; }
        public double? empsalary { get; set; }
    }
}
