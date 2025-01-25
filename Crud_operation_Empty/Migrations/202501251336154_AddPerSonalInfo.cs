namespace Crud_operation_Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPerSonalInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Self_Information",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mono = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Self_Information");
        }
    }
}
