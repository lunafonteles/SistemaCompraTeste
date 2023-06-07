using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaCompra.Domain.Core;
using SistemaCompra.Infra.Data.Produto;
using SistemaCompra.Infra.Data.SolicitacaoCompra;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;
using SolicitacaoAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data {
    public class SistemaCompraContext : DbContext {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public SistemaCompraContext(DbContextOptions options) : base(options) { }
        public DbSet<ProdutoAgg.Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Ignore<Event>();
            modelBuilder.Entity<SolicitacaoAgg.SolicitacaoCompra>().Ignore(s => s.TotalGeral);
            //modelBuilder.Entity<Money>()
            //.Property(m => m.Value)
            //.HasColumnType("decimal(18, 2)");

            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new SolicitacaoCompraConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=SistemaCompraDB;User Id=luna;Password=a123456;MultipleActiveResultSets=true");
        }

        public void SeedData() {
            var produto = new ProdutoAgg.Produto("Produto01", "Descricao01", "Madeira", 100);
            Produtos.Add(produto);

            SaveChanges();
        }
    }
}