namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Type");
        }
    }
}
