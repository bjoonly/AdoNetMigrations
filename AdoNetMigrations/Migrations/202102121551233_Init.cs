namespace AdoNetMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.ArtistId)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AlbumId = c.Int(),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlaylistSongs",
                c => new
                    {
                        Playlist_Id = c.Int(nullable: false),
                        Song_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_Id, t.Song_Id })
                .ForeignKey("dbo.Playlists", t => t.Playlist_Id, cascadeDelete: true)
                .ForeignKey("dbo.Songs", t => t.Song_Id, cascadeDelete: true)
                .Index(t => t.Playlist_Id)
                .Index(t => t.Song_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlaylistSongs", "Song_Id", "dbo.Songs");
            DropForeignKey("dbo.PlaylistSongs", "Playlist_Id", "dbo.Playlists");
            DropForeignKey("dbo.Playlists", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Songs", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Artists", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.PlaylistSongs", new[] { "Song_Id" });
            DropIndex("dbo.PlaylistSongs", new[] { "Playlist_Id" });
            DropIndex("dbo.Playlists", new[] { "CategoryId" });
            DropIndex("dbo.Songs", new[] { "AlbumId" });
            DropIndex("dbo.Artists", new[] { "CountryId" });
            DropIndex("dbo.Albums", new[] { "GenreId" });
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropTable("dbo.PlaylistSongs");
            DropTable("dbo.Categories");
            DropTable("dbo.Playlists");
            DropTable("dbo.Songs");
            DropTable("dbo.Genres");
            DropTable("dbo.Countries");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
