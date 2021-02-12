using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MusicCollection mc = new MusicCollection();
                mc.ShowSongsNumberListeningMoreThanAvg("To Hell With Hollywood");
                Console.WriteLine(new String('-',150));
                mc.ShowTop3AlbumsByRating("Morgan", "Parriott");
                Console.WriteLine(new String('-', 150));

                mc.ShowTop3SongsByRating("Morgan", "Parriott");
                Console.WriteLine(new String('-', 150));
                mc.SearchBySongName("Cash");
                Console.WriteLine(new String('-', 150));
                mc.SearchByText("Holly");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
