namespace _1811190667_NguyenQuocCuong_BigSchool01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Followings");
            AddColumn("dbo.Followings", "CourseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Followings", new[] { "CourseId", "FollowerId", "FolloweeId" });
            CreateIndex("dbo.Followings", "CourseId");
            AddForeignKey("dbo.Followings", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "CourseId", "dbo.Courses");
            DropIndex("dbo.Followings", new[] { "CourseId" });
            DropPrimaryKey("dbo.Followings");
            DropColumn("dbo.Followings", "CourseId");
            AddPrimaryKey("dbo.Followings", new[] { "FollowerId", "FolloweeId" });
        }
    }
}
