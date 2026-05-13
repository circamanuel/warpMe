using WarpMe.Data;
using WarpMe.Data.Models;

namespace WarpMe.Services
{
    public class ThemeService
    {
        private AppDbContext _db;

        public ThemeService(AppDbContext db)
        {
            _db = db;
        }
        
        // Read
        public ProfileTheme? GetProfileTheme(int id)
        {
            return _db.ProfileThemes.FirstOrDefault(t => t.ProfileId == id);
        }

        // Update
        public void UpdateProfileTheme(ProfileTheme theme)
        {
            _db.ProfileThemes.Update(theme);
            _db.SaveChanges();
        }

        // Delete

        public void DeleteProfileTheme(int id)
        {
            var profileTheme = _db.ProfileThemes.FirstOrDefault(t => t.ProfileId == id);

            if (profileTheme != null)
            {
                _db.ProfileThemes.Remove(profileTheme);
                _db.SaveChanges();
            }
        }
    }
}
