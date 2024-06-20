using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    public double Score { get; set; }
}

class Program
{
    static List<Student> studentList = new List<Student>();

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Chương trình quản lý danh sách sinh viên");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Thoát");

            Console.Write("Chọn chức năng: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
                case 3:
                    CalculateTotalScore();
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddStudent()
    {
        Student newStudent = new Student();

        Console.Write("Nhập tên sinh viên: ");
        newStudent.Name = Console.ReadLine();

        Console.Write("Nhập lớp của sinh viên: ");
        newStudent.Class = Console.ReadLine();

        Console.Write("Nhập điểm của sinh viên: ");
        newStudent.Score = double.Parse(Console.ReadLine());

        studentList.Add(newStudent);
        Console.WriteLine("Đã thêm sinh viên mới vào danh sách.");
    }

    static void DisplayStudents()
    {
        if (studentList.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống.");
            return;
        }

        Console.WriteLine("Danh sách sinh viên:");
        foreach (var student in studentList)
        {
            Console.WriteLine($"Tên: {student.Name}, Lớp: {student.Class}, Điểm: {student.Score}");
        }
    }

    static void CalculateTotalScore()
    {
        double totalScore = 0;
        foreach (var student in studentList)
        {
            totalScore += student.Score;
        }

        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {totalScore}");
    }
}