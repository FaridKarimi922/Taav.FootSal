using Librari.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Ef.Players
{
    public class PlayerEntityMap : IEntityTypeConfiguration<player>
    {
        public void Configure(EntityTypeBuilder<player> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).ValueGeneratedOnAdd();
            builder.Property(_ => _.Name).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.BirthDate).IsRequired();

            builder.
                HasOne(_ => _.Team)
                .WithMany(_ => _.Players)
                .HasForeignKey(_ => _.TeamId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
