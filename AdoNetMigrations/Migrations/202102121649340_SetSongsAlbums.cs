namespace AdoNetMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSongsAlbums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Rating", c => c.Single(nullable: false));
            AddColumn("dbo.Songs", "Rating", c => c.Single(nullable: false));
            AddColumn("dbo.Songs", "NumberOfPlays", c => c.Int(nullable: false));
            AddColumn("dbo.Songs", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Text");
            DropColumn("dbo.Songs", "NumberOfPlays");
            DropColumn("dbo.Songs", "Rating");
            DropColumn("dbo.Albums", "Rating");
        }
    }
}
