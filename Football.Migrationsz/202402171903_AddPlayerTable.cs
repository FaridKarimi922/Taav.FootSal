using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrationss
{
    [Migration(202402171903)]
    public class _202402171903_AddPlayerTable : Migration
    {
        public override void Up()
        {
            Create.Table("Players")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("Name").AsString(50).NotNullable()
                   .WithColumn("BirthDate").AsDateTime().NotNullable()
                   .WithColumn("TeamId").AsInt32().NotNullable()
                   .ForeignKey("Fk_Players_Teams", "Teams", "Id");
        }
        public override void Down()
        {
            Delete.Table("Players");
        }

        
    }
}
