using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra {
    public class SolicitacaoCompraConfiguration : IEntityTypeConfiguration<SolicitacaoCompraAgg.SolicitacaoCompra> {
        public void Configure(EntityTypeBuilder<SolicitacaoCompraAgg.SolicitacaoCompra> builder) {
            builder.ToTable("SolicitacaoCompra");
            builder.OwnsOne(c => c.NomeFornecedor, b => b.Property<string>("Value").HasColumnName("NomeFornecedor"));
            builder.OwnsOne(c => c.UsuarioSolicitante, b => b.Property<string>("Value").HasColumnName("UsuarioSolicitante"));

        }
    }
}
