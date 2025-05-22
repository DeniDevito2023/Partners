using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Partners.Model;

public partial class PartnersSaleContext : DbContext
{
    public PartnersSaleContext()
    {
    }

    public PartnersSaleContext(DbContextOptions<PartnersSaleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MaterialType> MaterialTypes { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<SalePartnersProduct> SalePartnersProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PartnersSale;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MaterialType>(entity =>
        {
            entity.HasKey(e => e.IdMaterialType).HasName("MaterialType_pkey");

            entity.ToTable("MaterialType");

            entity.Property(e => e.IdMaterialType).HasColumnName("idMaterialType");
            entity.Property(e => e.TypeMaterial).HasColumnType("character varying");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.IdPartners).HasName("Partners_pkey");

            entity.Property(e => e.IdPartners).HasColumnName("idPartners");
            entity.Property(e => e.Address)
                .HasColumnType("character varying")
                .HasColumnName("address");
            entity.Property(e => e.Director).HasColumnType("character varying");
            entity.Property(e => e.Email).HasColumnType("character varying");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.NamePartners)
                .HasColumnType("character varying")
                .HasColumnName("namePartners");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.TypePartners).HasColumnType("character varying");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProducts).HasName("Products_pkey");

            entity.Property(e => e.IdProducts).HasColumnName("idProducts");
            entity.Property(e => e.MinPriceForPartners).HasColumnName("minPriceForPartners");
            entity.Property(e => e.NameProducts).HasColumnType("character varying");
            entity.Property(e => e.TypeProducts).HasColumnName("typeProducts");

            entity.HasOne(d => d.TypeProductsNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.TypeProducts)
                .HasConstraintName("Products_typeProducts_fkey");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.IdProductTypeCoff).HasName("ProductType_pkey");

            entity.ToTable("ProductType");

            entity.Property(e => e.IdProductTypeCoff).HasColumnName("idProductTypeCoff");
            entity.Property(e => e.TypeProductsCoff)
                .HasColumnType("character varying")
                .HasColumnName("typeProductsCoff");
        });

        modelBuilder.Entity<SalePartnersProduct>(entity =>
        {
            entity.HasKey(e => e.IdSaleProductPartners).HasName("SalePartnersProduct_pkey");

            entity.ToTable("SalePartnersProduct");

            entity.Property(e => e.IdSaleProductPartners).HasColumnName("idSaleProductPartners");
            entity.Property(e => e.SaleNameProductsFk).HasColumnName("SaleNameProductsFK");
            entity.Property(e => e.SaleProductFk).HasColumnName("SaleProductFK");

            entity.HasOne(d => d.SaleNameProductsFkNavigation).WithMany(p => p.SalePartnersProducts)
                .HasForeignKey(d => d.SaleNameProductsFk)
                .HasConstraintName("SalePartnersProduct_SaleNameProductsFK_fkey");

            entity.HasOne(d => d.SaleProductFkNavigation).WithMany(p => p.SalePartnersProducts)
                .HasForeignKey(d => d.SaleProductFk)
                .HasConstraintName("SalePartnersProduct_SaleProductFK_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
