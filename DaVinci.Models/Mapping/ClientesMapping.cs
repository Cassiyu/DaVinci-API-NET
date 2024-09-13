using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaVinci.Models.Mapping
{
    public class ClientesMapping : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {   

            builder.ToTable("TB_DV_CLIENTE");

            builder.HasKey(p => p.IdCliente);

            builder.Property(p => p.Nome)
               .HasAnnotation("Nome", "Nome do cliente � obrigatorio");

            builder.Property(p => p.Email)
               .HasAnnotation("Email", "Email do cliente � obrigatorio");

            builder.Property(p => p.Sexo)
               .HasAnnotation("Sexo", "Sexo do cliente � obrigatorio");

            builder.Property(p => p.Cidade)
               .HasAnnotation("Cidade", "Cidade do cliente � obrigatorio");

            builder.Property(p => p.Cpf)
               .HasAnnotation("Cpf", "CPF do cliente � obrigatorio");
        }
    }
}