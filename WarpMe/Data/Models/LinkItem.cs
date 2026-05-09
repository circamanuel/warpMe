using Microsoft.Extensions.Primitives;

namespace WarpMe.Data.Models
{
    public class LinkItem
    {
        public int Id { get; set; } 
        public int ProfileId { get; set; }  
        public string Title { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public bool IsVisible   { get; set; }

    }
}
