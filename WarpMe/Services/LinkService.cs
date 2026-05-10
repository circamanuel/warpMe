using WarpMe.Data;
using WarpMe.Data.Models;

namespace WarpMe.Services
{
    public class LinkService
    {
        private AppDbContext _db;

        public LinkService(AppDbContext db)
        {
            _db = db;
        }

        // Create new Link
        public void AddLinkItem(LinkItem item)
        {
           _db.LinkItems.Add(item); 
           _db.SaveChanges();
        }

        // read Link
        public LinkItem? GetLinkItem(int id)
        {
            return _db.LinkItems.FirstOrDefault(l => l.Id == id);
        }

        public List<LinkItem> GetLinkList(int profileId)
        {
            var links = _db.LinkItems.Where(x => x.ProfileId == profileId).ToList();
            return links;
        }

        // Update Link
        public void UpdateLinkItem(LinkItem item)
        {
            _db.Update(item);
            _db.SaveChanges();
        }

       // Delete Link
        public void DeleteLinkItem(LinkItem item) 
        { 
            _db.LinkItems.Remove(item);
            _db.SaveChanges();
        }
    }
}
