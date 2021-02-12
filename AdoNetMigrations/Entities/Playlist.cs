﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdoNetMigrations { 
    public class Playlist
    {
        public Playlist()
        {
            this.Songs = new HashSet<Song>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }



        public virtual ICollection<Song> Songs { get; set; }
        public virtual Category Category { get; set; }
    }
}