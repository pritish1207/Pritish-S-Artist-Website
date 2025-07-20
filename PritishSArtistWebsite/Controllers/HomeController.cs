using Microsoft.AspNetCore.Mvc;
using PritishSArtistWebsite.Models;
using System.Diagnostics;

namespace PritishSArtistWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var artist = GetArtistData();
            return View(artist);
        }

        public IActionResult Music()
        {
            var artist = GetArtistData();
            return View(artist.Songs);
        }

        public IActionResult About()
        {
            var artist = GetArtistData();
            return View(artist);
        }

        public IActionResult Contact()
        {
            var artist = GetArtistData();
            return View(artist);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private Artist GetArtistData()
        {
            var artist = new Artist
            {
                Bio = "Pritish S (Pritish Sewsunker) is a 21-year-old electronic music producer and DJ from Edenvale, Gauteng, South Africa. Born on September 7, 2003, he specializes in house and electronic music production but is always experimenting with different genres, having released multiple EP's including his acclaimed Electric Euphoria series. His music blends modern electronic elements with smooth transitions and aesthetic soundscapes, establishing him as a rising talent in the South African electronic music scene and is always open to dive into different experiences."
            };


            artist.Songs = new List<Song>
            {
                new Song { Id = 1, Title = "GROUNDSHAKER", Featuring = "feat. Junkiie", Album = "Electric Euphoria III", Year = "2025", Genre = "Dubstep", CoverUrl = "/images/electric3.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 2, Title = "DEXTERITY", Album = "Electric Euphoria III", Year = "2025", Genre = "RnB", CoverUrl = "/images/electric3.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 3, Title = "BAD HABITS", Album = "BAD HABITS - Electric Euphoria III", Year = "2025", Genre = "House", CoverUrl = "/images/electric3.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 4, Title = "STARSHIPS", Album = "STARSHIPS - Electric Euphoria III", Year = "2025", Genre = "Retro", CoverUrl = "/images/electric3.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 5, Title = "STAY WITH ME", Album = "STAY WITH ME - Electric Euphoria III", Year = "2025", Genre = "Afro House", CoverUrl = "/images/electric3.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 6, Title = "HeartBeat", Album = "HeartBeat - Single", Year = "2025", Genre = "House", CoverUrl = "/images/HEARBEAT.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 7, Title = "AGE AINT NOTING BUT A NUMBER", Album = "AGE AINT NOTING BUT A NUMBER - Single", Year = "2025", Genre = "House", CoverUrl = "/images/AGE.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 8, Title = "Loving You", Album = "Loving You - Single", Year = "2025", Genre = "Cinematic", CoverUrl = "/images/LOVINGYOU.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 9, Title = "All The Time", Album = "All The Time - Single", Year = "2024", Genre = "RnB", CoverUrl = "/images/ALLTHETIME.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 10, Title = "Vibracao Descontraida", Album = "Vibracao Descontraida - Single", Year = "2024", Genre = "House", CoverUrl = "/images/VIBRA.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 11, Title = "Love Me", Album = "Love Me - Single", Year = "2024", Genre = "House", CoverUrl = "/images/LOVEME.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 12, Title = "EUNOIA", Album = "Electric Euphoria II", Year = "2024", Genre = "LoFi", CoverUrl = "/images/EE2.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 13, Title = "SUIT N TIES", Album = "Electric Euphoria II", Year = "2024", Genre = "House", CoverUrl = "/images/EE2.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 14, Title = "CALYPSO", Album = "Electric Euphoria II", Year = "2024", Genre = "Afro House", CoverUrl = "/images/EE2.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 15, Title = "DYSTOPIA", Album = "Electric Euphoria II", Year = "2024", Genre = "Dubstep", CoverUrl = "/images/EE2.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 16, Title = "NOT IN LOVE", Album = "Electric Euphoria II", Year = "2024", Genre = "House", Featuring = "Kaylene", CoverUrl = "/images/EE2.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 17, Title = "RAGE!", Album = "RAGE!", Year = "2024", Genre = "Dubstep", CoverUrl = "/images/RAGE.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 18, Title = "Static Groove", Album = "Static Groove - Single", Year = "2024", Genre = "Amapiano", Featuring = "Pritish S, Don Shak, Bradyd", CoverUrl = "/images/STATIC.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 19, Title = "BLUEBERRY EXPRESS", Album = "BLUEBERRY EXPRESS", Year = "2024", Genre = "Tropical", CoverUrl = "/images/BLUEBERRY.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 20, Title = "Perfect", Album = "Perfect", Year = "2023", Genre = "Ambient", CoverUrl = "/images/PERFECT.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 21, Title = "REMINISCENCE", Album = "Strings & Contrast", Year = "2023", Genre = "EDM", CoverUrl = "/images/STRINGS.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 22, Title = "MIDNIGHT TALES", Album = "Strings & Contrast", Year = "2023", Genre = "House", CoverUrl = "/images/STRINGS.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 23, Title = "GIZA", Album = "Strings & Contrast", Year = "2023", Genre = "House", CoverUrl = "/images/STRINGS.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 24, Title = "Catch Me - Pritish S Remix", Album = "Catch Me (Pritish S Remix)", Year = "2023", Genre = "House", Featuring = "Betty Boo", CoverUrl = "/images/CATCHME.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 25, Title = "Cybernetic Reverberation", Album = "Electric Euphoria I", Year = "2023", Genre = "Trap", CoverUrl = "/images/EE1.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 26, Title = "All I Ever Wanted", Album = "Electric Euphoria I", Year = "2023", Genre = "RnB", CoverUrl = "/images/EE1.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 27, Title = "You", Album = "Electric Euphoria I", Year = "2023", Genre = "Ambient", Featuring = "Kaylene", CoverUrl = "/images/EE1.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 28, Title = "New York", Album = "Electric Euphoria I", Year = "2023", Genre = "RnB", CoverUrl = "/images/EE1.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 29, Title = "Senorita", Album = "Electric Euphoria I", Year = "2023", Genre = "House", CoverUrl = "/images/EE1.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 30, Title = "Drugs", Album = "Drugs", Year = "2024", Genre = "Pop", Featuring = "Kaylene", CoverUrl = "/images/DRUGS.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 31, Title = "Tell Me (High Pitch)", Album = "Tell Me (High Pitch)", Year = "2023", Genre = "Ambient", CoverUrl = "/images/TELLMEHIGH.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 32, Title = "Tell Me", Album = "Tell Me", Year = "2023", Genre = "Ambient", CoverUrl = "/images/TELLME.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 33, Title = "Ama Prits", Album = "Ama Prits", Year = "2023", Genre = "Amapiano", CoverUrl = "/images/AMAPRITS.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 34, Title = "Bass Ride", Album = "Bass Ride", Year = "2021", Genre = "House", CoverUrl = "/images/BASSRIDE.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 35, Title = "Coffee", Album = "Coffee", Year = "2020", Genre = "LoFi", CoverUrl = "/images/COFFEE.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 36, Title = "Shiva", Album = "Shiva", Year = "2020", Genre = "Trap", CoverUrl = "/images/SHIVA.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 37, Title = "Memories", Album = "Memories", Year = "2020", Genre = "Future Bass", CoverUrl = "/images/MEMORIES.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 38, Title = "Good Vibes", Album = "Good Vibes", Year = "2020", Genre = "Future Bass", CoverUrl = "/images/GOODVIBES.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 39, Title = "Hasta el Fuego", Album = "Hasta el Fuego", Year = "2020", Genre = "Trap", CoverUrl = "/images/HASTA.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 40, Title = "On One", Album = "On One", Year = "2020", Genre = "House", CoverUrl = "/images/ONONE.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 41, Title = "U Thought", Album = "U Thought", Year = "2020", Genre = "Trap", CoverUrl = "/images/UTHOUGHT.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
                new Song { Id = 42, Title = "Odyssey", Album = "Odyssey", Year = "2020", Genre = "House", CoverUrl = "/images/ODY.jpg", SpotifyUrl = "https://open.spotify.com/track/...", AppleMusicUrl = "https://music.apple.com/za/album/...", YouTubeUrl = "https://youtu.be/..." },
            };
            

            return artist;
        }
    }
}
