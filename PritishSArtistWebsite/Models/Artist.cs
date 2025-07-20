namespace PritishSArtistWebsite.Models
{
    public class Artist
    {
        public string Name { get; set; } = "Pritish S";
        public string RealName { get; set; } = "Pritish Sewsunker";
        public string Bio { get; set; } = "";
        public string Location { get; set; } = "Edenvale, Gauteng, South Africa";
        public DateTime BirthDate { get; set; } = new DateTime(2003, 9, 7);
        public string Genre { get; set; } = "House & Electronic Music";
        public string Email { get; set; } = "pritish7712@gmail.com";
        public string InstagramHandle { get; set; } = "_f.l.x.m.e_";
        public string InstagramUrl { get; set; } = "https://instagram.com/_f.l.x.m.e_";
        public string SpotifyUrl { get; set; } = "https://open.spotify.com/artist/3hTnQmNsFA0l2QAFh7NKBv?si=xRduvkjJR0ymbCg3oOCVjw";
        public string AppleMusicUrl { get; set; } = "https://music.apple.com/us/artist/pritish-s/1512613636";
        public string YoutubeUrl { get; set; } = "https://youtube.com/channel/@@flame7";
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
