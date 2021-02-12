using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdoNetMigrations
{
    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Year { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        public float Rating { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}