namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seddUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20b6bb76-e546-4dd4-a8c5-1558baaf0dbb', N'guest@vidly.com', 0, N'AIE0as/sHiSD27V49M6ILNMhmONGlQcBl4oN6sS5Q/JnMmmrgCU7IkDilBOWdSub1A==', N'4b2ea1ea-5c92-4f0d-99cd-fda9428da85a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'265e04ae-7814-4df3-b6fc-5530a06eb4ab', N'admin@vidly.com', 0, N'AMzyFg1ZKaJ0cChMKEKAmJKd7EHHhNarNXzWpFvS5gJJnTfep2F6xtbghS8IZjF/IA==', N'b0fbee70-18ad-4b4c-8080-11081f89f397', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd93841ac-fb42-4b89-94eb-d12428dd2b30', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'265e04ae-7814-4df3-b6fc-5530a06eb4ab', N'd93841ac-fb42-4b89-94eb-d12428dd2b30')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
