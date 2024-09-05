using System.ComponentModel.DataAnnotations;

namespace MVCApplicationForAssignment.Models
{
    public class User
    {
        [Key]
        public int Uid {  get; set; }
        public string ?Username { get; set; }
        public string ?UserMail {  get; set; }
        //navigator User post
        public ICollection<Post>? Post {  get; set; }



    }
}
