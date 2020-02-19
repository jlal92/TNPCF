namespace TNPCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tblMembershipType", newName: "tblMembership");
            DropForeignKey("dbo.tblMember", "MembershipType_ID", "dbo.tblMembershipType");
            DropIndex("dbo.tblMember", new[] { "MembershipType_ID" });
            DropColumn("dbo.tblMember", "MembershipId");
            RenameColumn(table: "dbo.tblMember", name: "MembershipType_ID", newName: "MembershipId");
            AlterColumn("dbo.tblMember", "MembershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblMember", "MembershipId");
            AddForeignKey("dbo.tblMember", "MembershipId", "dbo.tblMembership", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblMember", "MembershipId", "dbo.tblMembership");
            DropIndex("dbo.tblMember", new[] { "MembershipId" });
            AlterColumn("dbo.tblMember", "MembershipId", c => c.Int());
            RenameColumn(table: "dbo.tblMember", name: "MembershipId", newName: "MembershipType_ID");
            AddColumn("dbo.tblMember", "MembershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblMember", "MembershipType_ID");
            AddForeignKey("dbo.tblMember", "MembershipType_ID", "dbo.tblMembershipType", "ID");
            RenameTable(name: "dbo.tblMembership", newName: "tblMembershipType");
        }
    }
}
