using System;
using Newtonsoft;

namespace MyApp
{
	public class Program
	{
		// tạo hàm hiển thị Menu
		public static void HienThi_Menu()
		{
			Console.WriteLine("1. Nhap du lieu tu file data.json");
			Console.WriteLine("2. Hien thi danh sach lop hoc");
			Console.WriteLine("3. Luu");
			Console.WriteLine("4. Thoat");
			
			// xuống dòng
			Console.WriteLine();
		}



		// tạo hàm đọc dữ liệu từ file .json
		// với tham số là đối tượng có kiểu List<LopHoc>
		public static List<LopHoc> Doc_File_JSON(List<LopHoc> danhSach)
		{
			// đọc dữ liệu từ file data.json
			// tôi sẽ ghi dữ liệu đọc được vào biến "text_json"
			string text_json = System.IO.File.ReadAllText(@"data.json");

			// Console.WriteLine(text_json);

			// chuyển JSON thành mảng Object Class trong C#
			// sử dụng NuGet Packages
			// để thêm thư viện Newtonsoft.Json
			danhSach = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LopHoc>>(text_json);

			Console.WriteLine($"Length = {danhSach.Count()}\n");

			return danhSach;
		}



		// tạo hàm hiển thị cái danh sách
		// sau khi đã chuyển từ JSON sang Object
		// với tham số là đối tượng có kiểu List<LopHoc>
		public static void HienThi_KetQua(List<LopHoc> danhSach)
		{
			foreach (LopHoc item in danhSach)
			{
				item.HienThi_LopHoc();

				// xuống dòng
				Console.WriteLine();
			}
		}



		public static void Main(string[] args)
		{
			// tạo đối tượng danh sách
			List<LopHoc> ds = new List<LopHoc>();

			// tạo biến lựa chọn
			int lua_chon = 0;

			do
			{
				// gọi hàm hiển thị Menu
				HienThi_Menu();

				// nhập vào lựa chọn từ bàn phím
				lua_chon = int.Parse(Console.ReadLine());

				switch (lua_chon)
				{
					case 1:
						// đọc dữ liệu từ file .json
						// sau đó chuyển JSON sang danh sách
						// kết quả sẽ được hứng bởi đối tượng ds
						ds = Doc_File_JSON(ds);
						break;
					
					case 2:
						// hiển thị dữ liệu
						// sau khi chuyển từ JSON sang Object Class
						HienThi_KetQua(ds);
						break;

					case 3:
						// chỗ này thì viết code tạo ra file .json bằng C#
						break;

					case 4:
						Console.WriteLine("Da thoat chuong trinh.");
						break;

					default:
						// khi bạn nhập lựa chọn khác 1, 2, 3, 4
						// thì nó sẽ thoát khỏi vòng lặp
						Console.WriteLine("Nhap sai!");
						break;
				}
			}
			while (lua_chon != 4);

		}
	}
}