using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace shoppingAPI.Models.EF
{
    public partial class shoppingDBContext : DbContext
    {
        public shoppingDBContext()
        {
        }

        public shoppingDBContext(DbContextOptions<shoppingDBContext> options)
            : base(options)
        {
        }        

        public virtual DbSet<OrdersList> OrdersLists { get; set; } = null!;
        public virtual DbSet<ProductList> ProductLists { get; set; } = null!;
        public virtual DbSet<Register> Registers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:nikhils-p2.database.windows.net,1433;Initial Catalog=shoppingDB;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdersList>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ordersLi__0809335DC46891C1");

                entity.ToTable("ordersList");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.OrderCost).HasColumnName("orderCost");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("orderDate");

                entity.Property(e => e.OrderQty).HasColumnName("orderQty");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersLists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_produtId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrdersLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_userId");
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__productL__DD36D562378C8978");

                entity.ToTable("productList");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("pId");

                entity.Property(e => e.PAvailableQty).HasColumnName("pAvailableQty");

                entity.Property(e => e.PCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pCategory");

                entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");

                entity.Property(e => e.PName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pName");

                entity.Property(e => e.PPrice).HasColumnName("pPrice");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.DesiredUserName)
                    .HasName("PK__Register__8FB802682A330244");

                entity.ToTable("Register");

                entity.HasIndex(e => e.ContactNo, "uk_contact")
                    .IsUnique();

                entity.HasIndex(e => e.EmailAddress, "uk_email")
                    .IsUnique();

                entity.Property(e => e.DesiredUserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("desiredUserName");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNo).HasColumnName("contactNo");

                entity.Property(e => e.DesiredPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("desiredPassword");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lastName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
