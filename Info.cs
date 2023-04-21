using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocvien
{
   
    struct SinhVien
    {
        public string HoTen;
        public string GioiTinh;
        public DateTime NgaySinh;
        public string TruongHoc;
        public string NoiO;
        public string QueQuan;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien[] danhSachSinhVien =
            {
            new SinhVien { HoTen = "Trần Minh Đức", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 2, 13), TruongHoc = "Trường Kinh doanh Công nghệ", NoiO = "Hà Nội", QueQuan = "Hải Dương" },
            new SinhVien { HoTen = "Lê Hồng Nhung", GioiTinh = "Nữ", NgaySinh = new DateTime(2004, 8, 25), TruongHoc = "Trường Đại học Kinh tế quốc dân", NoiO = "Chung cư hoàng huy", QueQuan = "Thanh Hóa" },
            new SinhVien { HoTen = "Vũ Đức Nam", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 5, 10), TruongHoc = "Cao đẳng fpt ponitechnich", NoiO = "Hà Nội", QueQuan = "Hải Dương" },
            new SinhVien { HoTen = "Lê Đinh Hùng Anh", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 4, 27), TruongHoc = "Lam Sơn", NoiO = "ktx Bách Khoa", QueQuan = "Thanh hóa" },
            new SinhVien { HoTen = "Nguyễn Trần Minh", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 3, 25), TruongHoc = "Bách Khoa", NoiO = "250 minh khai", QueQuan = "Thái Bình" },
            new SinhVien { HoTen = "Lê Xuân Phúc", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 2, 17), TruongHoc = "Bách Khoa", NoiO = "Hà Nội", QueQuan = "Thanh Hóa" },
            new SinhVien { HoTen = "Hòang Trung Khải", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 10, 9), TruongHoc = "Bách Khoa", NoiO = "hoàng mai", QueQuan = " thanh hóa" },
            new SinhVien { HoTen = "Bùi Quốc Bảo", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 8, 14), TruongHoc = "Bách khoa", NoiO = "đống đa", QueQuan = "thanh hóa" },
            new SinhVien { HoTen = "nguyễn ngọc châu", GioiTinh = "Nam", NgaySinh = new DateTime(2001, 1, 17), TruongHoc = "đại học cần thơ", NoiO = "cần thơ", QueQuan = "sóc trăng" },
            new SinhVien { HoTen = "nguyễn công nghĩa", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 5, 3), TruongHoc = "hb âcdemy", NoiO = "hà nội", QueQuan = "hà nội" },
            new SinhVien { HoTen = "nguyễn chiều dương", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 11, 9), TruongHoc = "greenwich", NoiO = "Vinhome", QueQuan = "hà nội" },
            new SinhVien { HoTen = "đặng thành long", GioiTinh = "Nam", NgaySinh = new DateTime(1999, 7, 16), TruongHoc = "hb academy", NoiO = "hà nội", QueQuan = "hà nam" },
           
        };

            Console.WriteLine("Danh sách sinh viên:");

            for (int i = 0; i < danhSachSinhVien.Length; i++)
            {
                Console.WriteLine("Sinh viên thứ " + (i + 1) + ":");
                Console.WriteLine("Họ tên: " + danhSachSinhVien[i].HoTen);
                Console.WriteLine("Giới tính: " + danhSachSinhVien[i].GioiTinh);
                Console.WriteLine("Ngày sinh: " + danhSachSinhVien[i].NgaySinh.ToString("dd/MM/yyyy"));
                Console.WriteLine("Trường học: " + danhSachSinhVien[i].TruongHoc);
                Console.WriteLine("Nơi ở: " + danhSachSinhVien[i].NoiO);
                Console.WriteLine("Quê quán: " + danhSachSinhVien[i].QueQuan);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
