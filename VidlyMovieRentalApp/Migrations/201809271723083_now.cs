namespace VidlyMovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class now : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            //DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            //DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            //DropIndex("dbo.Movies", new[] { "GenreId" });
            //DropColumn("dbo.Customers", "MembershipTypeId");
            //RenameColumn(table: "dbo.Customers", name: "MembershipType_Id", newName: "MembershipTypeId");
            //DropPrimaryKey("dbo.MembershipTypes");
            //DropPrimaryKey("dbo.Genres");
            //AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            //AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            //AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            //AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            //AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            //AddPrimaryKey("dbo.MembershipTypes", "Id");
            //AddPrimaryKey("dbo.Genres", "Id");
            //CreateIndex("dbo.Customers", "MembershipTypeId");
            //CreateIndex("dbo.Movies", "GenreId");
            //AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            //DropColumn("dbo.Customers", "BirthDay");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Customers", "BirthDay", c => c.DateTime());
            //DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            //DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            //DropIndex("dbo.Movies", new[] { "GenreId" });
            //DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            //DropPrimaryKey("dbo.Genres");
            //DropPrimaryKey("dbo.MembershipTypes");
            //AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            //AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            //AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            //AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Int());
            //DropColumn("dbo.Customers", "Birthdate");
            //AddPrimaryKey("dbo.Genres", "Id");
            //AddPrimaryKey("dbo.MembershipTypes", "Id");
            //RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipType_Id");
            //AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            //CreateIndex("dbo.Movies", "GenreId");
            //CreateIndex("dbo.Customers", "MembershipType_Id");
            //AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
