namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            DropColumn("dbo.Writers", "About");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "About", c => c.String(maxLength: 100));
            DropColumn("dbo.Writers", "WriterAbout");
        }
    }
}
