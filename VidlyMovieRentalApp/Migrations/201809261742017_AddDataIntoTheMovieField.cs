namespace VidlyMovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataIntoTheMovieField : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Movies(Name, ReleasedDate , DateAdded , NumberInStock,GenreId) VALUES ('ToyStory','12-04-2000',01-01-2000, 3 , 1)");
        }
        
        public override void Down()
        {
        }
    }
}
