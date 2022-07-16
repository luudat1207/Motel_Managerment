using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class DBNhaTroContext : DbContext
    {
        public DBNhaTroContext()
        {
        }

        public DBNhaTroContext(DbContextOptions<DBNhaTroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chunha> Chunhas { get; set; }
        public virtual DbSet<Cthoadon> Cthoadons { get; set; }
        public virtual DbSet<Dichvu> Dichvus { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Hopdong> Hopdongs { get; set; }
        public virtual DbSet<Khachthue> Khachthues { get; set; }
        public virtual DbSet<Phongtro> Phongtros { get; set; }
        public virtual DbSet<Thanhtoan> Thanhtoans { get; set; }
        public virtual DbSet<Tinhtrang> Tinhtrangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =LAPTOP-8GV359RE; database = DBNhaTro; uid=sa; pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Chunha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHUNHA");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DiaChi");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GhiChu");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(50)
                    .HasColumnName("HoTen");

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<Cthoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CTHOADON");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");
            });

            modelBuilder.Entity<Dichvu>(entity =>
            {
                entity.HasKey(e => e.MaDv);

                entity.ToTable("DICHVU");

                entity.Property(e => e.MaDv)
                    .ValueGeneratedNever()
                    .HasColumnName("MaDV");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenDv)
                    .HasMaxLength(50)
                    .HasColumnName("TenDV");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HOADON");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.Idtt).HasColumnName("IDTT");

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.SoHopDong).HasMaxLength(50);
            });

            modelBuilder.Entity<Hopdong>(entity =>
            {
                entity.HasKey(e => e.SoHopDong);

                entity.ToTable("HOPDONG");

                entity.Property(e => e.SoHopDong).HasMaxLength(50);

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DuKienTra).HasColumnType("date");

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.MaPhong).HasMaxLength(50);

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.Property(e => e.TuNgay).HasColumnType("date");
            });

            modelBuilder.Entity<Khachthue>(entity =>
            {
                entity.HasKey(e => e.Cccd);

                entity.ToTable("KHACHTHUE");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HoTen)
                    .HasMaxLength(50)
                    .HasColumnName("Ho Ten");

                entity.Property(e => e.QueQuan).HasMaxLength(500);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.ThongTinKhac).HasMaxLength(500);
            });

            modelBuilder.Entity<Phongtro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PHONGTRO");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaPhong).HasMaxLength(50);

                entity.Property(e => e.ThongTin).HasMaxLength(500);
            });

            modelBuilder.Entity<Thanhtoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("THANHTOAN");

                entity.Property(e => e.Idtt).HasColumnName("IDTT");

                entity.Property(e => e.LoaiThanhToan).HasMaxLength(500);
            });

            modelBuilder.Entity<Tinhtrang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TINHTRANG");

                entity.Property(e => e.TinhTrang1)
                    .HasMaxLength(500)
                    .HasColumnName("TinhTrang");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
