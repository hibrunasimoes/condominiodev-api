using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using condominiodev_api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace condominiodev_api.Database.Mappings
{
    public class HabitanteMap : IEntityTypeConfiguration<Habitante>
    {
        public void Configure(EntityTypeBuilder<Habitante> builder)
        {
            builder.ToTable("Habitantes");
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id)
               .HasColumnType("int");

            builder
                .Property(h => h.Nome)
                .HasMaxLength(255)
                .IsRequired();
            builder
                .Property(h => h.Sobrenome)
                .HasMaxLength(255);
            builder
                .Property(h => h.DataNascimento);
            builder
                .Property(h => h.Renda)
                .HasPrecision(18, 2);
            builder
                .Property(h => h.CPF);
        }
    }
}