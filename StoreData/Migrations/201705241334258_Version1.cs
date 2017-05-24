namespace StoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Desciption", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Desciption");
        }
    }
}
