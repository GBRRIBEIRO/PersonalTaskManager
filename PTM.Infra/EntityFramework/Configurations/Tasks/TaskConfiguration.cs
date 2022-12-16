using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTM.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Infra.EntityFramework.Configurations.Tasks
{
    public class TaskConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.ToTable("Task");

            builder
                .Property<Guid>(_ => _.Id)
                .HasColumnType("TEXT")
                .IsRequired();

            builder
                .Property<string>(_ => _.Title)
                .IsRequired();

            builder
                .Property<string>(_ => _.Description)
                .IsRequired();

            builder
                .Property<DateTime>(_ => _.CreatedOn)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder
                .Property<DateTime>(_ => _.StartDateTime)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder
               .Property<DateTime>(_ => _.FinishedDateTime)
               .HasColumnType("DATETIME")
               .IsRequired();

            builder
               .Property<int>(_ => _.Status)
               .IsRequired();
        }
    }
}
