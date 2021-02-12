using AdoNetMigrations.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetMigrations
{
   
    class MusicCollection
    {
        MyDbContext dbContext;

        public MusicCollection()
        {
            dbContext = new MyDbContext();
        }
        public void ShowSongsNumberListeningMoreThanAvg(string album)
        {
            var res = dbContext.Songs.Where(s => s.Album.Name == album);
            if (res.Any())
            {
                double  avg = res.Average(s => s.NumberOfPlays);
                ShowSongs(dbContext.Songs.Where(s => s.Album.Name == album).Where(s => s.NumberOfPlays > avg));
            }
        }
        public void ShowTop3AlbumsByRating(string name,string surname)
        {

           ShowAlbums(dbContext.Albums.Where(a=>a.Artist.Name==name && a.Artist.Surname==surname).OrderByDescending(a => a.Rating).Take(3));
        }
        public void ShowTop3SongsByRating(string name, string surname)
        {
         ShowSongs(dbContext.Songs.Where(a => a.Album.Artist.Name == name && a.Album.Artist.Surname == surname).OrderByDescending(s => s.Rating).Take(3));
        }
        public void SearchBySongName(string name)
        {
            ShowSongs(dbContext.Songs.Where(s => s.Name.Contains(name)));
        }
        public void SearchByText(string text)
        {
 
            ShowSongs(dbContext.Songs.Where(s => s.Text.Contains(text)));
        }

        public void ShowAlbums(IEnumerable<Album> albums)
        {
            int count = 1;
            foreach (var album in albums)
            {
                Console.WriteLine("{0,3}. {1,-25} {2,-25} {3,-5}",count,album.Name, album.Artist.Name,album.Rating);
            }
        }

        public void ShowSongs(IEnumerable<Song> songs)
        {
            int count = 1;
            foreach (var song in songs)
            {
                Console.WriteLine("{0,3}.{1,-25} {2,-10} {3,-3} {4,-5}\n{5,-200}", count, song.Name, song.Duration,song.Rating,song.NumberOfPlays,song.Text);
                count++;

            }
        }
        
    }
    }
