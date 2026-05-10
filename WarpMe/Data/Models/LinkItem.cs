using Microsoft.Extensions.Primitives;

namespace WarpMe.Data.Models
{
    public class LinkItem
    {
        public int Id { get; set; } 
        public int ProfileId { get; set; }  
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public int? Order { get; set; }
        public bool IsVisible { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
