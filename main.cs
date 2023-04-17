using System;
using System.IO;
using System.Reflection.Emit;
using static System.Console;

namespace HomeWork3
{
    public class Program
    {
        
        public struct HocVien
        {
            public string HoTen;
            public string GioiTinh;
            public string NgaySinh;
            public string Truong;
            public string DiaChi;
            public string QueQuan;
        }
        static void Main(string[] args)
        {
            WriteLine("1");
            HocVien HV1= new HocVien();
            HV1.HoTen = "Lee Nhung";
            HV1.GioiTinh = "Nu";
            HV1.NgaySinh = "25/08/2004";
            HV1.Truong = "NEU";
            HV1.DiaChi = "Chung Cu Hoang Huy";
            HV1.QueQuan = "Thanh Hoa";          
            WriteLine("Ho ten: " + HV1.HoTen);
            WriteLine("Gioi Tinh: " + HV1.GioiTinh);
            WriteLine("Ngay sinh: " + HV1.NgaySinh);
            WriteLine("Truong hien tai: " + HV1.Truong);
            WriteLine("Dia chi: " + HV1.DiaChi);
            WriteLine("Que quan: " + HV1.QueQuan);
            WriteLine();

            WriteLine("2");
            HocVien HV2 = new HocVien();
            HV2.HoTen = "Dang Thanh Long";
            HV2.GioiTinh = "Nam";
            HV2.NgaySinh = "16/07/1999";
            HV2.Truong = "HB ACADEMY";
            HV2.DiaChi = "Ha Noi";
            HV2.QueQuan = "Ha Nam";
            WriteLine("Ho ten: " + HV2.HoTen);
            WriteLine("Gioi Tinh: " + HV2.GioiTinh);
            WriteLine("Ngay sinh: " + HV2.NgaySinh);
            WriteLine("Truong hien tai: " + HV2.Truong);
            WriteLine("Dia chi: " + HV2.DiaChi);
            WriteLine("Que quan: " + HV2.QueQuan);
            WriteLine();

            WriteLine("3");
            HocVien HV3 = new HocVien();
            HV3.HoTen = "Nguyen Trieu Duong";
            HV3.GioiTinh = "Nam";
            HV3.NgaySinh = "09/11/2004";
            HV3.Truong = "Greenwich";
            HV3.DiaChi = "Vinhomes Ocean Park";
            HV3.QueQuan = "Ha Noi";
            WriteLine("Ho ten: " + HV3.HoTen);
            WriteLine("Gioi Tinh: " + HV3.GioiTinh);
            WriteLine("Ngay sinh: " + HV3.NgaySinh);
            WriteLine("Truong hien tai: " + HV3.Truong);
            WriteLine("Dia chi: " + HV3.DiaChi);
            WriteLine("Que quan: " + HV3.QueQuan);
            WriteLine();

            WriteLine("4");
            HocVien HV4 = new HocVien();
            HV4.HoTen = "Nguyen Cong Nghia";
            HV4.GioiTinh = "Nam";
            HV4.NgaySinh = "03/05/2002";
            HV4.Truong = "Hb Academy";
            HV4.DiaChi = "Ha Noi";
            HV4.QueQuan = "Ha Noi";
            WriteLine("Ho ten: " + HV4.HoTen);
            WriteLine("Gioi Tinh: " + HV4.GioiTinh);
            WriteLine("Ngay sinh: " + HV4.NgaySinh);
            WriteLine("Truong hien tai: " + HV4.Truong);
            WriteLine("Dia chi: " + HV4.DiaChi) ;
            WriteLine("Que quan: " + HV4.QueQuan);
            WriteLine();

            WriteLine("5");
            HocVien HV5 = new HocVien();
            HV5.HoTen = "Nguyen Ngoc Chau";
            HV5.GioiTinh = "Nam";
            HV5.NgaySinh = "17/01/2001";
            HV5.Truong = "Dai hoc Can Tho";
            HV5.DiaChi = "Can Tho";
            HV5 .QueQuan = "Soc Trang";
            WriteLine("Ho ten: " + HV5.HoTen);
            WriteLine("Gioi Tinh: " + HV5.GioiTinh);
            WriteLine("Ngay sinh: " + HV5.NgaySinh);
            WriteLine("Truong hien tai: " + HV5.Truong);
            WriteLine("Dia chi: " + HV5.DiaChi);
            WriteLine("Que quan: " + HV5.QueQuan);
            WriteLine();

            WriteLine("6");
            HocVien HV6 = new HocVien();
            HV6.HoTen = "Bui Quoc Bao";
            HV6.GioiTinh = "Nam";
            HV6.NgaySinh = "14/08/2004";
            HV6.Truong = "HUST";
            HV6.DiaChi = "Dong Da";
            HV6.QueQuan = "Thanh Hoa";
            WriteLine("Ho ten: " + HV6.HoTen);
            WriteLine("Gioi Tinh: " + HV6.GioiTinh);
            WriteLine("Ngay sinh: " + HV6.NgaySinh);
            WriteLine("Truong hien tai: "+ HV6.Truong);
            WriteLine("Dia chi: " + HV6.DiaChi);
            WriteLine("Que quan: " + HV6.QueQuan);
            WriteLine();

            WriteLine("7");
            HocVien HV7 = new HocVien();
            HV7.HoTen = "Nguyen Quang Huy";
            HV7.GioiTinh = "Nam";
            HV7.NgaySinh = "25/09/2002";
            HV7.Truong = "FPT Polytechnic";
            HV7.DiaChi = "Nam Tu Liem, Ha Noi";
            HV7.QueQuan = "Ha Noi";
            WriteLine("Ho ten: " + HV7.HoTen);
            WriteLine("Gioi Tinh: " + HV7.GioiTinh);
            WriteLine("Ngay sinh: " + HV7.NgaySinh);
            WriteLine("Truong hien tai: " + HV7.Truong);
            WriteLine("Dia chi: " + HV7.DiaChi);
            WriteLine("Que quan: " + HV7.QueQuan);
            WriteLine();

            WriteLine("8");
            HocVien HV8 = new HocVien();
            HV8.HoTen = "Hoang Trung Khai";
            HV8 .GioiTinh = "Nam";
            HV8.NgaySinh = "09/10/2004";
            HV8.Truong = "HUST";
            HV8.DiaChi = "Ha Noi";
            HV8.QueQuan = "Thanh Hoa";
            WriteLine("Ho ten: " + HV8.HoTen);
            WriteLine("Gioi Tinh: " + HV8.GioiTinh);
            WriteLine("Ngay sinh: " + HV8.NgaySinh);
            WriteLine("Truong hien tai: " + HV8.Truong);
            WriteLine("Dia chi: " + HV8.DiaChi);
            WriteLine("Que quan: " + HV8.QueQuan);
            WriteLine();

            WriteLine("9");
            HocVien HV9 = new HocVien();
            HV9.HoTen = "Le Xuan Phuc";
            HV9.GioiTinh = "Nam";
            HV9.NgaySinh = "17/02/2004";
            HV9.Truong = "HUST";
            HV9.DiaChi = "Ha Noi";
            HV9.QueQuan = "Thanh Hoa";
            WriteLine("Ho ten: " + HV9.HoTen);
            WriteLine("Gioi Tinh: " + HV9.GioiTinh);
            WriteLine("Ngay sinh: " + HV9.NgaySinh);
            WriteLine("Truong hien tai: " + HV9.Truong);
            WriteLine("Dia chi: " + HV9.DiaChi);
            WriteLine("Que quan: " + HV9.QueQuan);
            WriteLine();

            WriteLine("10");
            HocVien HV10 = new HocVien();
            HV10.HoTen = "Nguyen Tran Minh";
            HV10.GioiTinh = "Nam";
            HV10.NgaySinh = "25/03/2003";
            HV10.Truong = "HUST";
            HV10.DiaChi = "250 Minh Khai";
            HV10.QueQuan = "Thai Binh";
            WriteLine("Ho ten: " + HV10.HoTen);
            WriteLine("Gioi Tinh: " + HV10.GioiTinh);
            WriteLine("Ngay sinh: " + HV10.NgaySinh);
            WriteLine("Truong hien tai: " + HV10.Truong);
            WriteLine("Dia chi: " + HV10.DiaChi);
            WriteLine("Que quan: " + HV10.QueQuan);
            WriteLine();

        }




    }
   
    

}
