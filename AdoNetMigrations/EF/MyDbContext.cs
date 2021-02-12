namespace AdoNetMigrations.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyDbContext")
        {
            Database.SetInitializer(new Initializer());
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<Song> Songs { get; set; }



    }
}