namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class radiohead : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        content = c.String(),
                        sender_username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.sender_username)
                .Index(t => t.sender_username);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                        User_username = c.String(maxLength: 128),
                        Message_ID = c.Int(),
                    })
                .PrimaryKey(t => t.username)
                .ForeignKey("dbo.Users", t => t.User_username)
                .ForeignKey("dbo.Messages", t => t.Message_ID)
                .Index(t => t.User_username)
                .Index(t => t.Message_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "sender_username", "dbo.Users");
            DropForeignKey("dbo.Users", "Message_ID", "dbo.Messages");
            DropForeignKey("dbo.Users", "User_username", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Message_ID" });
            DropIndex("dbo.Users", new[] { "User_username" });
            DropIndex("dbo.Messages", new[] { "sender_username" });
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
        }
    }
}
