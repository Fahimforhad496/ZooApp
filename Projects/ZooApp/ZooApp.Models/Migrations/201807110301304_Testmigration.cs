namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Quantity", c => c.String());
        }
    }
}
