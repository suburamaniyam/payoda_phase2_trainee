using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApplicationForAssignment.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string ?Title { get; set; }

        public string ?PostContent {  get; set; }
        public double CreatedDate {  get; set; }
        public  int Userid { get; set; }
        [ForeignKey("Userid")]
        public User? User { get; set; }
    }
}
