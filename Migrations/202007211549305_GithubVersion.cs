namespace codefirstapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GithubVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "District", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "District");
        }
    }
}
