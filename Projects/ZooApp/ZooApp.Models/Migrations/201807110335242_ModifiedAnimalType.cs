namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedAnimalType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "Type", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Type", c => c.String());
        }
    }
}
