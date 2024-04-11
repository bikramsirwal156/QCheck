using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.Tabelneeded;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;

public class TodoListConfig : IEntityTypeConfiguration<TodoList>
{
    public void Configure(EntityTypeBuilder<TodoList> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .OwnsOne(b => b.Colour);
    }
}
