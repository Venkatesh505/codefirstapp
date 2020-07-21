namespace codefirstapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialVersion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayersID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PlayersID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
