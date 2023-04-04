namespace Idea1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Comment_id = c.Int(nullable: false, identity: true),
                        Comment_text = c.String(),
                        Comment_date = c.DateTime(nullable: false),
                        Comment_like = c.Int(nullable: false),
                        Comment_dislike = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Comment_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
