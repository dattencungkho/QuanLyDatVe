namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<BangGia> BangGias { get; set; }
        public virtual DbSet<ChiTietLaiXe> ChiTietLaiXes { get; set; }
        public virtual DbSet<ChiTietLoTrinh> ChiTietLoTrinhs { get; set; }
        public virtual DbSet<ChiTietVeXe> ChiTietVeXes { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<ChuyenXe> ChuyenXes { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DiemTrungChuyen> DiemTrungChuyens { get; set; }
        public virtual DbSet<DoiTuong> DoiTuongs { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kip> Kips { get; set; }
        public virtual DbSet<LoTrinh> LoTrinhs { get; set; }
        public virtual DbSet<ManHinhQuanLy> ManHinhQuanLies { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<QuyenManHinhQuanLy> QuyenManHinhQuanLies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<TrangThaiGhe> TrangThaiGhes { get; set; }
        public virtual DbSet<TrangThaiVeXe> TrangThaiVeXes { get; set; }
        public virtual DbSet<VeXe> VeXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangGia>()
                .Property(e => e.madiemtrungchuyendon)
                .IsUnicode(false);

            modelBuilder.Entity<BangGia>()
                .Property(e => e.madiemtrungchuyentra)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLaiXe>()
                .Property(e => e.manhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLaiXe>()
                .Property(e => e.giaypheplaixe)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLaiXe>()
                .Property(e => e.hanglai)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLaiXe>()
                .Property(e => e.ngaycap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLoTrinh>()
                .Property(e => e.machitietlotrinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLoTrinh>()
                .Property(e => e.malotrinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLoTrinh>()
                .Property(e => e.idtinhthanh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietVeXe>()
                .Property(e => e.chitietvexeId)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietVeXe>()
                .Property(e => e.vexeId)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietVeXe>()
                .Property(e => e.maghe)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.machuyenxe)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.malotrinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.makip)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.maxe)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.mataixe)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.maphuxe)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .HasMany(e => e.VeXes)
                .WithRequired(e => e.ChuyenXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.madanhgia)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.makhachhang)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.maxe)
                .IsUnicode(false);

            modelBuilder.Entity<DiemTrungChuyen>()
                .Property(e => e.madiemtrungchuyen)
                .IsUnicode(false);

            modelBuilder.Entity<DiemTrungChuyen>()
                .Property(e => e.matinh)
                .IsUnicode(false);

            modelBuilder.Entity<DiemTrungChuyen>()
                .HasMany(e => e.BangGias)
                .WithOptional(e => e.DiemTrungChuyen)
                .HasForeignKey(e => e.madiemtrungchuyendon);

            modelBuilder.Entity<DiemTrungChuyen>()
                .HasMany(e => e.BangGias1)
                .WithOptional(e => e.DiemTrungChuyen1)
                .HasForeignKey(e => e.madiemtrungchuyentra);

            modelBuilder.Entity<DoiTuong>()
                .Property(e => e.madoituong)
                .IsUnicode(false);

            modelBuilder.Entity<DoiTuong>()
                .HasMany(e => e.KhachHangs)
                .WithRequired(e => e.DoiTuong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ghe>()
                .Property(e => e.maghe)
                .IsUnicode(false);

            modelBuilder.Entity<Ghe>()
                .Property(e => e.maxe)
                .IsUnicode(false);

            modelBuilder.Entity<Ghe>()
                .HasMany(e => e.TrangThaiGhes)
                .WithRequired(e => e.Ghe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.khachhangId)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.madoituong)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.matkhau)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DanhGias)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.makhachhang);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.VeXes)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kip>()
                .Property(e => e.makip)
                .IsUnicode(false);

            modelBuilder.Entity<Kip>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.Kip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoTrinh>()
                .Property(e => e.malotrinh)
                .IsUnicode(false);

            modelBuilder.Entity<LoTrinh>()
                .Property(e => e.matinhtra)
                .IsFixedLength();

            modelBuilder.Entity<LoTrinh>()
                .Property(e => e.matinhdon)
                .IsFixedLength();

            modelBuilder.Entity<LoTrinh>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.LoTrinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ManHinhQuanLy>()
                .Property(e => e.tenmanhinh)
                .IsUnicode(false);

            modelBuilder.Entity<ManHinhQuanLy>()
                .HasMany(e => e.QuyenManHinhQuanLies)
                .WithRequired(e => e.ManHinhQuanLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.manhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.socmt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ngaycap)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChiTietLaiXes)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.mataixe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChuyenXes1)
                .WithRequired(e => e.NhanVien1)
                .HasForeignKey(e => e.maphuxe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .Property(e => e.maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.QuyenManHinhQuanLies)
                .WithRequired(e => e.Quyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.Quyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuyenManHinhQuanLy>()
                .Property(e => e.maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.linklaylaitaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TinhThanh>()
                .Property(e => e.matinh)
                .IsUnicode(false);

            modelBuilder.Entity<TinhThanh>()
                .HasMany(e => e.ChiTietLoTrinhs)
                .WithOptional(e => e.TinhThanh)
                .HasForeignKey(e => e.idtinhthanh);

            modelBuilder.Entity<TinhThanh>()
                .HasMany(e => e.DiemTrungChuyens)
                .WithRequired(e => e.TinhThanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrangThaiGhe>()
                .Property(e => e.maghe)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.vexeId)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.machuyenxe)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.khachhangId)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.tongtien)
                .IsFixedLength();

            modelBuilder.Entity<VeXe>()
                .Property(e => e.madiemtrungchuyendon)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.madiemtrungchuyentra)
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .HasMany(e => e.ChiTietVeXes)
                .WithRequired(e => e.VeXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.maxe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.biensoxe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.Ghes)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);
        }
    }
}
