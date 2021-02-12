using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdoNetMigrations
{
    public class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}