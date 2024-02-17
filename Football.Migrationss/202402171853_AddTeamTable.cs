using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrationss
{

    [Migration(202402171853)]
    public class _202402171853_AddTeamTable : Migration
    {
        public override void Up()
        {
            Create.Table("Teams")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("Name").AsString(50).NotNullable()
                   .WithColumn("Origine").AsInt32().NotNullable()
                   .WithColumn("Sub").AsString(50).NotNullable();

        }
        public override void Down()
        {
            Delete.Table("Teams");
        }

    }
}
