using System;

namespace MyApp
{
	public class LopHoc
	{
		public string ten_lop { get; set; }
		public string dia_chi { get; set; }
		public List<SinhVien> danh_sach_SinhVien { get; set; }



		// hàm khởi tạo không tham số
		public LopHoc()
		{
			ten_lop = string.Empty;
			dia_chi = string.Empty;

			danh_sach_SinhVien = new List<SinhVien>();
		}



		// hàm nhập dữ liệu lớp học
		public void NhapDuLieu_LopHoc()
		{
			Console.WriteLine("Nhap ten lop hoc: ");
			ten_lop = Console.ReadLine();

			Console.WriteLine("Nhap dia chi lop hoc: ");
			dia_chi = Console.ReadLine();

			Console.WriteLine("Nhap so luong sinh vien: ");
			int n = Convert.ToInt32(Console.ReadLine());

			// dùng vòng lặp for để nhập n sinh viên
			for (int i = 0; i < n; i++)
			{
				// tạo đối tượng sinh viên
				SinhVien dt = new SinhVien();

				// gọi phương thức nhập dữ liệu
				dt.NhapDuLieu();

				// thêm phần tử dt vào danh sách sinh viên
				danh_sach_SinhVien.Add(dt);
			}
		}



		// hàm hiển thị lớp học
		public void HienThi_LopHoc()
		{
			Console.WriteLine($"Ten lop hoc: {ten_lop}");
			Console.WriteLine($"Dia chi lop hoc: {dia_chi}");

			// dùng vòng lặp foreach
			// để hiển thị sinh viên trong lớp học
			foreach (SinhVien item in danh_sach_SinhVien)
			{
				item.HienThi();
			}
		}
	}
}
