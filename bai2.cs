using System;
using System.Collections.Generic;

class bai2
{
    static Dictionary<string, string> englishVietnamDictionary = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        // Thêm một số từ vào từ điển
        AddWordToDict("hello", "xin chào");
        AddWordToDict("book", "sách");
        AddWordToDict("apple", "táo");
        AddWordToDict("house", "nhà");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Chương trình từ điển Anh-Việt");
            Console.WriteLine("1. Tra từ");
            Console.WriteLine("2. Thoát");

            Console.Write("Chọn chức năng: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LookupWord();
                    break;
                case 2:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddWordToDict(string english, string vietnamese)
    {
        if (englishVietnamDictionary.ContainsKey(english))
        {
            Console.WriteLine($"Từ '{english}' đã có trong từ điển.");
        }
        else
        {
            englishVietnamDictionary.Add(english, vietnamese);
            Console.WriteLine($"Đã thêm từ '{english}' vào từ điển.");
        }
    }

    static void LookupWord()
    {
        Console.Write("Nhập từ tiếng Anh cần tra: ");
        string englishWord = Console.ReadLine().ToLower();

        if (englishVietnamDictionary.ContainsKey(englishWord))
        {
            Console.WriteLine($"Nghĩa của từ '{englishWord}' là: {englishVietnamDictionary[englishWord]}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy từ '{englishWord}' trong từ điển.");
        }
    }
}