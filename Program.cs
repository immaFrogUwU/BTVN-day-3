using System;
using System.IO;
using static System.Console;

namespace HomeWork
{
    public class Program
    {
        enum Thang
        {
            Thang1 = 1,
            Thang2,
            Thang3,
            Thang4,
            Thang5,
            Thang6,
            Thang7,
            Thang8,
            Thang9,
            Thang10,
            Thang11,
            Thang12,
        }
        public static void Main()
        {                      
            int DaysInJan = DateTime.DaysInMonth(2023, (int)Thang.Thang1);
            WriteLine("So ngay trong thang 1 la: "+DaysInJan);
            
            int DaysInFeb = DateTime.DaysInMonth(2023, (int)Thang.Thang2);
            WriteLine("So ngay trong thang 2 la: "+ DaysInFeb);

            int DaysInMar = DateTime.DaysInMonth(2023, (int)Thang.Thang3);
            WriteLine("So ngay trong thang 3 la: "+ DaysInMar);

            int DaysInApr = DateTime.DaysInMonth(2023, (int)Thang.Thang4);
            WriteLine("So ngay trong thang 4 la: "+ DaysInApr);

            int DaysInMay = DateTime.DaysInMonth(2023, (int)Thang.Thang5);
            WriteLine("So ngay trong thang 5 la: "+ DaysInMay);

            int DaysInJun = DateTime.DaysInMonth(2023, (int)Thang.Thang6);
            WriteLine("So ngay trong thang 6 la: "+ DaysInJun);

            int DaysInJul = DateTime.DaysInMonth(2023, (int)Thang.Thang7);
            WriteLine("So ngay trong thang 7 la: "+ DaysInJul);

            int DaysInAug = DateTime.DaysInMonth(2023, (int)Thang.Thang8);
            WriteLine("So ngay trong thang 8 la: "+ DaysInAug);

            int DaysInSep = DateTime.DaysInMonth(2023, (int)Thang.Thang9);
            WriteLine("So ngay trong thang 9 la: "+ DaysInSep);

            int DaysInOct = DateTime.DaysInMonth(2023, (int)Thang.Thang10);
            WriteLine("So ngay trong thang 10 la: "+ DaysInOct);

            int DaysInNov = DateTime.DaysInMonth(2023, (int)Thang.Thang11);
            WriteLine("So ngay trong thang 11 la: "+ DaysInNov);

            int DaysInDec = DateTime.DaysInMonth(2023, (int)Thang.Thang12);
            WriteLine("So ngay trong thang 12 la: "+ DaysInDec);





        }
    }
}