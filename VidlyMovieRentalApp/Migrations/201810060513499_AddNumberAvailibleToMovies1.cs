namespace VidlyMovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailibleToMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailible = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
