namespace GoodQuestion.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenExpiration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUser", "TokenExpiration", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUser", "TokenExpiration");
        }
    }
}
