namespace MVC_RelationalDatabases.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Keys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherClasses",
                c => new
                    {
                        Teacher_ID = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_ID, t.Class_ID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Class_ID);
            
            AddColumn("dbo.Classes", "ClassName", c => c.String());
            AddColumn("dbo.Students", "StudentName", c => c.String());
            AddColumn("dbo.Students", "ClassId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "Name", c => c.String());
            CreateIndex("dbo.Students", "ClassId");
            AddForeignKey("dbo.Students", "ClassId", "dbo.Classes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.TeacherClasses", "Class_ID", "dbo.Classes");
            DropForeignKey("dbo.TeacherClasses", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.TeacherClasses", new[] { "Class_ID" });
            DropIndex("dbo.TeacherClasses", new[] { "Teacher_ID" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropColumn("dbo.Teachers", "Name");
            DropColumn("dbo.Students", "ClassId");
            DropColumn("dbo.Students", "StudentName");
            DropColumn("dbo.Classes", "ClassName");
            DropTable("dbo.TeacherClasses");
        }
    }
}
