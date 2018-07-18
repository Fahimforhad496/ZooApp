namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedAnimalId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Animals");
            AlterColumn("dbo.Animals", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Animals", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Animals");
            AlterColumn("dbo.Animals", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Animals", "Id");
        }
    }
}
