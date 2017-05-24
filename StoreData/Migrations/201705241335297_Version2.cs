namespace StoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Desciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desciption", c => c.String());
        }
    }
}