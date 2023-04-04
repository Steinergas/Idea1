namespace Idea1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcomment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Idea_IdeaId", c => c.Int());
            CreateIndex("dbo.Comments", "Idea_IdeaId");
            AddForeignKey("dbo.Comments", "Idea_IdeaId", "dbo.Ideas", "IdeaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Idea_IdeaId", "dbo.Ideas");
            DropIndex("dbo.Comments", new[] { "Idea_IdeaId" });
            DropColumn("dbo.Comments", "Idea_IdeaId");
        }
    }
}
