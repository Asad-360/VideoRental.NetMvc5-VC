namespace VidlyMovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailibleToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailible", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET NumberAvailible=NumberInStock ");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailible");
        }
    }
}
