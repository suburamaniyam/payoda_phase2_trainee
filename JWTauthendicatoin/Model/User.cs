using System.ComponentModel.DataAnnotations;
namespace JWTauthendicatoin.Model
{
    public class User
    {
        [Key]
        public int Userid { get; set; }
        public string? Username { get; set; }
        public string? usermailid { get; set; }
        public int? password { get; set; }

        
    }


}
