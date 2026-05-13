namespace WarpMe.Data.Models
{
    public class ProfileTheme
    {
        public int Id { get; set; } 
        public int ProfileId { get; set; }
        public string ProfileWallpaper { get; set; } = string.Empty;
        public string ProfileNameColor { get; set; } = string.Empty;
        public string ProfileFontFamily { get; set ; } = string.Empty; 
        public string ProfileButtonStyle {  get; set; } = string.Empty;
        public string ProfileButtonCorner {  get; set; } = string.Empty;
        public string ProfileButtonAccentColor {  get; set; } = string.Empty;
        public string ProfileButtonBackgroundColor {  get; set; } = string.Empty;
    }
}
