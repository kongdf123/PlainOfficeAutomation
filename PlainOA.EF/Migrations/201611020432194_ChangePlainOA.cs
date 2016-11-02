namespace PlainOA.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePlainOA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EmployeeAccount",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        Email = c.String(maxLength: 100),
                        Password = c.String(maxLength: 50),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(maxLength: 50),
                        DepartmentId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.Project_Id)
                .Index(t => t.DepartmentId)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(maxLength: 50),
                        DepartmentId = c.Int(nullable: false),
                        ProjectDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.TeamGroup",
                c => new
                    {
                        TeamGroupId = c.Int(nullable: false, identity: true),
                        TeamGroupName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TeamGroupId);
            
            CreateTable(
                "dbo.TeamGroupEmployee",
                c => new
                    {
                        TeamGroup_TeamGroupId = c.Int(nullable: false),
                        Employee_EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamGroup_TeamGroupId, t.Employee_EmployeeId })
                .ForeignKey("dbo.TeamGroup", t => t.TeamGroup_TeamGroupId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.Employee_EmployeeId, cascadeDelete: true)
                .Index(t => t.TeamGroup_TeamGroupId)
                .Index(t => t.Employee_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeAccount", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.TeamGroupEmployee", "Employee_EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.TeamGroupEmployee", "TeamGroup_TeamGroupId", "dbo.TeamGroup");
            DropForeignKey("dbo.Employee", "Project_Id", "dbo.Project");
            DropForeignKey("dbo.Project", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Employee", "DepartmentId", "dbo.Department");
            DropIndex("dbo.TeamGroupEmployee", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.TeamGroupEmployee", new[] { "TeamGroup_TeamGroupId" });
            DropIndex("dbo.Project", new[] { "DepartmentId" });
            DropIndex("dbo.Employee", new[] { "Project_Id" });
            DropIndex("dbo.Employee", new[] { "DepartmentId" });
            DropIndex("dbo.EmployeeAccount", new[] { "EmployeeId" });
            DropTable("dbo.TeamGroupEmployee");
            DropTable("dbo.TeamGroup");
            DropTable("dbo.Project");
            DropTable("dbo.Employee");
            DropTable("dbo.EmployeeAccount");
            DropTable("dbo.Department");
        }
    }
}
