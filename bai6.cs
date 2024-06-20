using System;
using System.Collections;

class bai6
{
    static void Main(string[] args)
    {
        // Tạo một Hashtable
        Hashtable myHashtable = new Hashtable();

        // Thêm các cặp key-giá trị vào Hashtable
        myHashtable.Add("name", "John Doe");
        myHashtable.Add(123, 456.789);
        myHashtable.Add(true, "true value");
        myHashtable.Add("array", new int[] { 1, 2, 3, 4, 5 });

        // Kiểm tra sự tồn tại của các key và giá trị
        Console.WriteLine("Contains key 'name'? " + myHashtable.ContainsKey("name"));
        Console.WriteLine("Contains value 456.789? " + myHashtable.ContainsValue(456.789));

        // Truy xuất giá trị bằng cách sử dụng chỉ mục
        Console.WriteLine("Value of key 'name': " + myHashtable["name"]);

        // Lặp lại các key và giá trị bằng vòng lặp foreach
        Console.WriteLine("\nAll keys and values:");
        foreach (DictionaryEntry entry in myHashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}