




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `MobileShopConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=PC;Initial Catalog=ShopDienThoai;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `True`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace MobileShopConnection
{

	public partial class MobileShopConnectionDB : Database
	{
		public MobileShopConnectionDB() 
			: base("MobileShopConnection")
		{
			CommonConstruct();
		}

		public MobileShopConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			MobileShopConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static MobileShopConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new MobileShopConnectionDB();
        }

		[ThreadStatic] static MobileShopConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static MobileShopConnectionDB repo { get { return MobileShopConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.__MigrationHistory")]



	[PrimaryKey("MigrationId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class __MigrationHistory : MobileShopConnectionDB.Record<__MigrationHistory>  
    {



		[Column] public string MigrationId { get; set; }





		[Column] public string ContextKey { get; set; }





		[Column] public byte[] Model { get; set; }





		[Column] public string ProductVersion { get; set; }



	}

    

	[TableName("dbo.AspNetRoles")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetRole : MobileShopConnectionDB.Record<AspNetRole>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }



	}

    

	[TableName("dbo.AspNetUserClaims")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class AspNetUserClaim : MobileShopConnectionDB.Record<AspNetUserClaim>  
    {



		[Column] public int Id { get; set; }





		[Column] public string UserId { get; set; }





		[Column] public string ClaimType { get; set; }





		[Column] public string ClaimValue { get; set; }



	}

    

	[TableName("dbo.AspNetUserLogins")]



	[PrimaryKey("LoginProvider", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserLogin : MobileShopConnectionDB.Record<AspNetUserLogin>  
    {



		[Column] public string LoginProvider { get; set; }





		[Column] public string ProviderKey { get; set; }





		[Column] public string UserId { get; set; }



	}

    

	[TableName("dbo.AspNetUserRoles")]



	[PrimaryKey("UserId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserRole : MobileShopConnectionDB.Record<AspNetUserRole>  
    {



		[Column] public string UserId { get; set; }





		[Column] public string RoleId { get; set; }



	}

    

	[TableName("dbo.AspNetUsers")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUser : MobileShopConnectionDB.Record<AspNetUser>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Email { get; set; }





		[Column] public bool EmailConfirmed { get; set; }





		[Column] public string PasswordHash { get; set; }





		[Column] public string SecurityStamp { get; set; }





		[Column] public string PhoneNumber { get; set; }





		[Column] public bool PhoneNumberConfirmed { get; set; }





		[Column] public bool TwoFactorEnabled { get; set; }





		[Column] public DateTime? LockoutEndDateUtc { get; set; }





		[Column] public bool LockoutEnabled { get; set; }





		[Column] public int AccessFailedCount { get; set; }





		[Column] public string UserName { get; set; }



	}

    

	[TableName("dbo.BinhLuan")]



	[PrimaryKey("MaBinhLuan")]




	[ExplicitColumns]

    public partial class BinhLuan : MobileShopConnectionDB.Record<BinhLuan>  
    {



		[Column] public int MaBinhLuan { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public int? MaSanPham { get; set; }





		[Column] public string TenTaiKhoan { get; set; }





		[Column] public string NoiDung { get; set; }





		[Column] public DateTime? ThoiGian { get; set; }





		[Column] public int? TinhTrang { get; set; }



	}

    

	[TableName("dbo.DonHang")]



	[PrimaryKey("MaDonHang")]




	[ExplicitColumns]

    public partial class DonHang : MobileShopConnectionDB.Record<DonHang>  
    {



		[Column] public int MaDonHang { get; set; }





		[Column] public int? MaTK { get; set; }





		[Column] public int? MaSP { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public int? GiaTien { get; set; }





		[Column] public int? MaTinhTrang { get; set; }





		[Column] public int? BiXoa { get; set; }



	}

    

	[TableName("dbo.GioHang")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class GioHang : MobileShopConnectionDB.Record<GioHang>  
    {



		[Column] public int id { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public int? MaSanPham { get; set; }





		[Column] public int? SoLuong { get; set; }



	}

    

	[TableName("dbo.HangSP")]



	[PrimaryKey("MaHang")]




	[ExplicitColumns]

    public partial class HangSP : MobileShopConnectionDB.Record<HangSP>  
    {



		[Column] public int MaHang { get; set; }





		[Column] public string TenHang { get; set; }





		[Column] public int? BiXoa { get; set; }



	}

    

	[TableName("dbo.LoaiSP")]



	[PrimaryKey("MaLoai")]




	[ExplicitColumns]

    public partial class LoaiSP : MobileShopConnectionDB.Record<LoaiSP>  
    {



		[Column] public int MaLoai { get; set; }





		[Column] public string TenLoai { get; set; }





		[Column] public int? BiXoa { get; set; }



	}

    

	[TableName("dbo.SanPham")]



	[PrimaryKey("MaSP")]




	[ExplicitColumns]

    public partial class SanPham : MobileShopConnectionDB.Record<SanPham>  
    {



		[Column] public int MaSP { get; set; }





		[Column] public string TenSP { get; set; }





		[Column] public int? MaHang { get; set; }





		[Column] public int? MaLoai { get; set; }





		[Column] public string HinhAnh { get; set; }





		[Column] public int? TinhTrang { get; set; }





		[Column] public int? GiaBan { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public int? BiXoa { get; set; }





		[Column] public string ChiTiet { get; set; }



	}

    

	[TableName("dbo.TinhThanh")]



	[PrimaryKey("MaTinhThanh")]




	[ExplicitColumns]

    public partial class TinhThanh : MobileShopConnectionDB.Record<TinhThanh>  
    {



		[Column] public int MaTinhThanh { get; set; }





		[Column] public string TenTinhThanh { get; set; }



	}

    

	[TableName("dbo.TinhTrangDH")]



	[PrimaryKey("MaTinhTrang")]




	[ExplicitColumns]

    public partial class TinhTrangDH : MobileShopConnectionDB.Record<TinhTrangDH>  
    {



		[Column] public int MaTinhTrang { get; set; }





		[Column] public string TenTinhTrang { get; set; }



	}

    

	[TableName("dbo.TinhTrangSP")]



	[PrimaryKey("MaTinhTrang")]




	[ExplicitColumns]

    public partial class TinhTrangSP : MobileShopConnectionDB.Record<TinhTrangSP>  
    {



		[Column] public int MaTinhTrang { get; set; }





		[Column] public string TenTinhTrang { get; set; }



	}

    

	[TableName("dbo.v_GioHang")]




	[ExplicitColumns]

    public partial class v_GioHang : MobileShopConnectionDB.Record<v_GioHang>  
    {



		[Column] public int id { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public int? MaSanPham { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public string TenSP { get; set; }





		[Column] public string HinhAnh { get; set; }





		[Column] public int? GiaBan { get; set; }





		[Column] public int? ThanhTien { get; set; }



	}


}
