namespace VidlyMovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'32592c00-b5cf-406f-9f85-bafa1a644734', N'guest@vidly.com', 0, N'AL1ZD1GWJnqCKnI+uZ3OZXyOH2BJOLMDn9pnqCZlVxOmgyQ6R3UfHiuzR4GhsgWIMQ==', N'950c0f00-2ee8-47cb-8d51-48de4b756b02', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'717bbf74-3fec-4cc4-8118-38f817c27ffc', N'admin@vidly.com', 0, N'ABnsIkYeOmjYMceQSftkdFSrnjgMgacrUzWCDZTdgJiWXO5YGLRVznBK9bM2YsXptg==', N'3ae05183-218e-4fe5-9fa2-f19fd4528450', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2bd4ab7c-24a9-4df3-818a-7350b20fd682', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'717bbf74-3fec-4cc4-8118-38f817c27ffc', N'2bd4ab7c-24a9-4df3-818a-7350b20fd682')

");
        }

        public override void Down()
        {
        }
    }
}
