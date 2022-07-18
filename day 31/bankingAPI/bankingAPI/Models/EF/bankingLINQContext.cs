using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace bankingAPI.Models.EF
{
    public partial class bankingLINQContext : DbContext
    {
        public bankingLINQContext()
        {
        }

        public bankingLINQContext(DbContextOptions<bankingLINQContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountsInfo> AccountsInfos { get; set; } = null!;
        public virtual DbSet<BranchInfo> BranchInfos { get; set; } = null!;
        public virtual DbSet<Transactioninfo> Transactioninfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=WIN8\\NIKHILINSTANCE; database=bankingLINQ ;user id=sa;password=Password1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsInfo>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("PK__Accounts__A4719705D5ECD359");

                entity.ToTable("AccountsInfo");

                entity.Property(e => e.AccNo)
                    .ValueGeneratedNever()
                    .HasColumnName("accNo");

                entity.Property(e => e.AccBalance).HasColumnName("accBalance");

                entity.Property(e => e.AccBranch).HasColumnName("accBranch");

                entity.Property(e => e.AccName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accName");

                entity.Property(e => e.AccType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accType");

                entity.HasOne(d => d.AccBranchNavigation)
                    .WithMany(p => p.AccountsInfos)
                    .HasForeignKey(d => d.AccBranch)
                    .HasConstraintName("fk_accBranch");
            });

            modelBuilder.Entity<BranchInfo>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK__branchIn__751EBD5FC0937E47");

                entity.ToTable("branchInfo");

                entity.Property(e => e.BranchId)
                    .ValueGeneratedNever()
                    .HasColumnName("branchId");

                entity.Property(e => e.BranchCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchCity");

                entity.Property(e => e.BranchEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("branchEmail");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchName");
            });

            modelBuilder.Entity<Transactioninfo>(entity =>
            {
                entity.HasKey(e => e.TrNo)
                    .HasName("PK__transact__9C31CC29CB84EB7D");

                entity.ToTable("transactioninfo");

                entity.Property(e => e.TrNo).HasColumnName("trNo");

                entity.Property(e => e.TrAmount).HasColumnName("trAmount");

                entity.Property(e => e.TrFromAccount).HasColumnName("trFromAccount");

                entity.Property(e => e.TrToAccount).HasColumnName("trToAccount");

                entity.Property(e => e.TrType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trType");

                entity.HasOne(d => d.TrFromAccountNavigation)
                    .WithMany(p => p.TransactioninfoTrFromAccountNavigations)
                    .HasForeignKey(d => d.TrFromAccount)
                    .HasConstraintName("fk_fromAccount");

                entity.HasOne(d => d.TrToAccountNavigation)
                    .WithMany(p => p.TransactioninfoTrToAccountNavigations)
                    .HasForeignKey(d => d.TrToAccount)
                    .HasConstraintName("fk_toAccount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
