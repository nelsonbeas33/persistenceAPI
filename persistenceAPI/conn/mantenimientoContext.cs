using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.db;

#nullable disable

namespace conn
{
    public partial class mantenimientoContext : DbContext
    {
        public mantenimientoContext()
        {
        }

        public mantenimientoContext(DbContextOptions<mantenimientoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatElementCategory> CatElementCategories { get; set; }
        public virtual DbSet<CatLineCategory> CatLineCategories { get; set; }
        public virtual DbSet<CatMaintenanceCategory> CatMaintenanceCategories { get; set; }
        public virtual DbSet<Element> Elements { get; set; }
        public virtual DbSet<ElementCategory> ElementCategories { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<LineCategory> LineCategories { get; set; }
        public virtual DbSet<LineElement> LineElements { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<MaintenanceCategory> MaintenanceCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=mantenimiento;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<CatElementCategory>(entity =>
            {
                entity.ToTable("cat_element_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CatLineCategory>(entity =>
            {
                entity.ToTable("cat_line_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CatMaintenanceCategory>(entity =>
            {
                entity.ToTable("cat_maintenance_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Element>(entity =>
            {
                entity.ToTable("element");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("path")
                    .IsFixedLength(true);

                entity.Property(e => e.ResX).HasColumnName("resX");

                entity.Property(e => e.ResY).HasColumnName("resY");
            });

            modelBuilder.Entity<ElementCategory>(entity =>
            {
                entity.ToTable("element_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatElementCategoryId).HasColumnName("cat_element_category_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.HasOne(d => d.CatElementCategory)
                    .WithMany(p => p.ElementCategories)
                    .HasForeignKey(d => d.CatElementCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__element_c__cat_e__662B2B3B");

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.ElementCategories)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__element_c__eleme__671F4F74");
            });

            modelBuilder.Entity<Line>(entity =>
            {
                entity.ToTable("line");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LineCategory>(entity =>
            {
                entity.ToTable("line_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatLineCategoryId).HasColumnName("cat_line_category_id");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.HasOne(d => d.CatLineCategory)
                    .WithMany(p => p.LineCategories)
                    .HasForeignKey(d => d.CatLineCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__line_cate__cat_l__625A9A57");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.LineCategories)
                    .HasForeignKey(d => d.LineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__line_cate__line___634EBE90");
            });

            modelBuilder.Entity<LineElement>(entity =>
            {
                entity.ToTable("line_element");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.Left)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Top)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.LineElements)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__line_elem__eleme__6DCC4D03");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.LineElements)
                    .HasForeignKey(d => d.LineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__line_elem__line___6EC0713C");
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.ToTable("maintenance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desc")
                    .IsFixedLength(true);

                entity.Property(e => e.FinalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("final_date");

                entity.Property(e => e.InicialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inicial_date");

                entity.Property(e => e.LineElementId).HasColumnName("line_element_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.RootCause)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("root_cause")
                    .IsFixedLength(true);

                entity.Property(e => e.SubCause)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_cause")
                    .IsFixedLength(true);

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<MaintenanceCategory>(entity =>
            {
                entity.ToTable("maintenance_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatMaintenanceCategoryId).HasColumnName("cat_maintenance_category_id");

                entity.Property(e => e.MaintenanceId).HasColumnName("maintenance_id");

                entity.HasOne(d => d.CatMaintenanceCategory)
                    .WithMany(p => p.MaintenanceCategories)
                    .HasForeignKey(d => d.CatMaintenanceCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__maintenan__cat_m__69FBBC1F");

                entity.HasOne(d => d.Maintenance)
                    .WithMany(p => p.MaintenanceCategories)
                    .HasForeignKey(d => d.MaintenanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__maintenan__maint__6AEFE058");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
