namespace TNPCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblMembershipType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.tblMember", "MembershipId", c => c.Int(nullable: false));
            AddColumn("dbo.tblMember", "MembershipType_ID", c => c.Int());
            CreateIndex("dbo.tblMember", "MembershipType_ID");
            AddForeignKey("dbo.tblMember", "MembershipType_ID", "dbo.tblMembershipType", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblMember", "MembershipType_ID", "dbo.tblMembershipType");
            DropIndex("dbo.tblMember", new[] { "MembershipType_ID" });
            DropColumn("dbo.tblMember", "MembershipType_ID");
            DropColumn("dbo.tblMember", "MembershipId");
            DropTable("dbo.tblMembershipType");
        }
    }
}
