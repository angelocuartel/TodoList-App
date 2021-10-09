using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_App.Models;

namespace TodoList_App.Data.EntityConfigurations
{
    public class TodoEntityConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("todo_table");

            builder.HasKey(i => i.TodoId);

            builder.Property(p => p.TodoTask)
                .HasColumnName("todo_task")
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnType("Varchar");
        }
    }
}
