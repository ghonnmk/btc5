using System;

public class Program
{
    public static void Main()
    {
        // Kiểm tra hàm Max với các kiểu dữ liệu khác nhau

        // Số nguyên
        int num1 = 10, num2 = 20;
        int maxInt = Max(num1, num2);
        Console.WriteLine($"Giá trị lớn nhất giữa {num1} và {num2} là: {maxInt}");

        // Số thực
        double dbl1 = 3.14, dbl2 = 2.71;
        double maxDouble = Max(dbl1, dbl2);
        Console.WriteLine($"Giá trị lớn nhất giữa {dbl1} và {dbl2} là: {maxDouble}");

        // Chuỗi
        string str1 = "Apple", str2 = "Banana";
        string maxString = Max(str1, str2);
        Console.WriteLine($"Giá trị lớn nhất giữa \"{str1}\" và \"{str2}\" là: {maxString}");
    }

    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
}