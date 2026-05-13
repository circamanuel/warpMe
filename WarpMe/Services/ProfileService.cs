using Microsoft.EntityFrameworkCore;
using WarpMe.Data;
using WarpMe.Data.Models;

namespace WarpMe.Services
{
    public class ProfileService
    {
        private AppDbContext _db;
        public ProfileService(AppDbContext db)  
        {
            _db = db;
        }

        //Load Profile and Save

        public UserProfile? GetUserProfile(int id)
        {
            return _db.UserProfiles.FirstOrDefault(p => p.Id == id);

        }

        public UserProfile? GetUserByUsername(string username)
        {
            return _db.UserProfiles.FirstOrDefault(u => u.Username == username);
        }

        public void UpdateUserProfile(UserProfile profile)
        {
            _db.UserProfiles.Update(profile);
            _db.SaveChanges();
        }

        public void DeleteUserProfile(int id)
        {
            var userProfile = _db.UserProfiles.FirstOrDefault(p => p.Id == id);
            if (userProfile != null)
            {
                _db.UserProfiles.Remove(userProfile);
                _db.SaveChanges();
            }

        }

    }
}
