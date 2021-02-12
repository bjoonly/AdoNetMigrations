using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdoNetMigrations

{
    public class Category
    {
        public Category()
        {
            this.Playlists = new HashSet<Playlist>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}