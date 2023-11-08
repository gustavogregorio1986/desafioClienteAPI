using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoClienteAPI.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteDTO>
    {
        public void Configure(EntityTypeBuilder<ClienteDTO> builder)
        {
            builder.ToTable("tb_Cliente");

            builder.HasKey(c => c.IdCliente);

            builder.Property(f => f.IdCliente)
               .HasColumnName("IdCliente")
               .IsRequired();

            builder.Property(f => f.NomeCliente)
               .HasColumnName("NomeCliente")
               .IsRequired();

            builder.Property(f => f.EmailCliente)
               .HasColumnName("EmailCliente")
               .IsRequired();

            builder.Property(f => f.Cpf)
               .HasColumnName("Cpf")
               .IsRequired();

            builder.Property(f => f.Sexo)
              .HasColumnName("Sexo")
              .IsRequired();
        }
    }
}
