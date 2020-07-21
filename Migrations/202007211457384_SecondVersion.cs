namespace codefirstapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "City", c => c.String());
            AddColumn("dbo.Players", "Pincode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Pincode");
            DropColumn("dbo.Players", "City");
        }
    }
}
