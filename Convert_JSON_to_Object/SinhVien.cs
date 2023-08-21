using System;

namespace MyApp
{
	public class SinhVien
	{
		public string ho_ten { get; set; }
		public string ngay_sinh { get; set; }
		public string email { get; set; }
		public string dia_chi { get; set; }
		public string gioi_tinh { get; set; }



		// hàm khởi tạo không tham số
		public SinhVien()
		{
			ho_ten = string.Empty;
			ngay_sinh = string.Empty;
			email = string.Empty;
			gioi_tinh = string.Empty;
			dia_chi = string.Empty;
		}



		// hàm nhập dữ liệu
		public void NhapDuLieu()
		{
			Console.Write("Nhap ho ten: ");
			ho_ten = Console.ReadLine();

			Console.Write("Nhap ngay sinh (dd-MM-yyyy): ");
			ngay_sinh = Console.ReadLine();

			Console.Write("Nhap email: ");
			email = Console.ReadLine();

			Console.Write("Nhap gioi tinh: ");
			gioi_tinh = Console.ReadLine();

			Console.Write("Nhap dia chi: ");
			dia_chi = Console.ReadLine();
		}



		// hàm hiển thị dữ liệu
		public void HienThi()
		{
			Console.WriteLine($"[{ho_ten}, {ngay_sinh}, {email}, {gioi_tinh}, {dia_chi}]");
		}
	}
}
