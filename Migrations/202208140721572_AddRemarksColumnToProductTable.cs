﻿namespace CRUDSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemarksColumnToProductTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Remarks");
        }
    }
}
