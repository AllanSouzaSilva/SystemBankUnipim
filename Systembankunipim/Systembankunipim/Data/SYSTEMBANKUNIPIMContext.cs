
using Microsoft.EntityFrameworkCore;

namespace Systembankunipim.Data
{
    public partial class SYSTEMBANKUNIPIMContext : DbContext
    {
        public SYSTEMBANKUNIPIMContext()
        {
        }
        public SYSTEMBANKUNIPIMContext(DbContextOptions<SYSTEMBANKUNIPIMContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TbCarteira> TbCarteira { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbInvestimento> TbInvestimento { get; set; }
        public virtual DbSet<TbTipoInvestimento> TbTipoInvestimento { get; set; }
        public virtual DbSet<TbTipoTransacao> TbTipoTransacao { get; set; }
        public virtual DbSet<TbTransacao> TbTransacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LTL89HV;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCarteira>(entity =>
            {
                entity.HasKey(e => e.IdCarteira)
                    .HasName("PK_Id_Carteira");

                entity.ToTable("TB_Carteira");

                entity.Property(e => e.IdCarteira).HasColumnName("Id_Carteira");

                entity.Property(e => e.DataUltimaTransacao)
                    .HasColumnName("Data_Ultima_Transacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.SaldoCarteira)
                    .HasColumnName("Saldo_Carteira")
                    .HasColumnType("decimal(30, 2)");

                entity.Property(e => e.UltimoDeposito)
                    .HasColumnName("Ultimo_Deposito")
                    .HasColumnType("decimal(30, 2)");

                entity.Property(e => e.UltimoSaque)
                    .HasColumnName("Ultimo_Saque")
                    .HasColumnType("decimal(30, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCarteira)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Id_Cliente");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_Id_Cliente");

                entity.ToTable("TB_Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DtNasc).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .IsUnicode(false);


                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<TbInvestimento>(entity =>
            {
                entity.HasKey(e => e.IdInvestimento)
                    .HasName("PK_Id_Investimento");

                entity.ToTable("TB_Investimento");

                entity.Property(e => e.IdInvestimento).HasColumnName("Id_Investimento");

                entity.Property(e => e.IdCarteira).HasColumnName("Id_Carteira");

                entity.Property(e => e.IdTipoInvestimento).HasColumnName("Id_Tipo_Investimento");

                entity.HasOne(d => d.IdCarteiraNavigation)
                    .WithMany(p => p.TbInvestimento)
                    .HasForeignKey(d => d.IdCarteira)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Id_Carteira");

                entity.HasOne(d => d.IdTipoInvestimentoNavigation)
                    .WithMany(p => p.TbInvestimento)
                    .HasForeignKey(d => d.IdTipoInvestimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Id_Tipo_Investimento");
            });

            modelBuilder.Entity<TbTipoInvestimento>(entity =>
            {
                entity.HasKey(e => e.IdTipoInvestimento)
                    .HasName("PK_Id_Tipo_Investimento");

                entity.ToTable("TB_Tipo_Investimento");

                entity.Property(e => e.IdTipoInvestimento).HasColumnName("Id_Tipo_Investimento");

                entity.Property(e => e.DescricaoInvestimento)
                    .IsRequired()
                    .HasColumnName("Descricao_Investimento")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValorInvestimento)
                    .HasColumnName("Valor_Investimento")
                    .HasColumnType("decimal(30, 2)");
            });

            modelBuilder.Entity<TbTipoTransacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoTransacao)
                    .HasName("PK_Id_Tipo_Transacao");

                entity.ToTable("TB_Tipo_Transacao");

                entity.Property(e => e.IdTipoTransacao).HasColumnName("Id_Tipo_Transacao");

                entity.Property(e => e.DescricaoTransacao)
                    .IsRequired()
                    .HasColumnName("Descricao_Transacao")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTransacao>(entity =>
            {
                entity.HasKey(e => e.IdTransacao)
                    .HasName("PK_Id_Transacao");

                entity.ToTable("TB_Transacao");

                entity.Property(e => e.IdTransacao).HasColumnName("Id_Transacao");

                entity.Property(e => e.AgenciaDestino).HasColumnName("Agencia_Destino");

                entity.Property(e => e.CarteiraDestino).HasColumnName("Carteira_Destino");

                entity.Property(e => e.ContaDestino).HasColumnName("Conta_Destino");

                entity.Property(e => e.IdCarteira).HasColumnName("Id_Carteira");

                entity.Property(e => e.IdTipoTransacao).HasColumnName("Id_Tipo_Transacao");

                entity.Property(e => e.ValorTransacao)
                    .HasColumnName("Valor_Transacao")
                    .HasColumnType("decimal(30, 2)");

                entity.HasOne(d => d.IdCarteiraNavigation)
                    .WithMany(p => p.TbTransacao)
                    .HasForeignKey(d => d.IdCarteira)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transacao_Id_Carteira");

                entity.HasOne(d => d.IdTipoTransacaoNavigation)
                    .WithMany(p => p.TbTransacao)
                    .HasForeignKey(d => d.IdTipoTransacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Id_Tipo_Transacao");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
