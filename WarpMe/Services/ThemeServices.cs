using WarpMe.Data;

namespace WarpMe.Services
{
    public class ThemeServices
    {
        private AppDbContext _db;

        public ThemeServices(AppDbContext db)
        {
            _db = db;
        }


    }
}
