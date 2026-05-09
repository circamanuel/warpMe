using System.ComponentModel;

namespace WarpMe.Data.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set;  }    
        public string ProfileImageUrl {  get; set; }

    }
}
