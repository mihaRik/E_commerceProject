namespace E_commerceProject_Electro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditProductTableAddImageColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImagePath");
        }
    }
}
