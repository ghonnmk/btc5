using System;
using System.Collections;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static ArrayList productList = new ArrayList();

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Chương trình quản lý sản phẩm");
            Console.WriteLine("1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm");
            Console.WriteLine("4. Thoát");

            Console.Write("Chọn chức năng: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProductList();
                    break;
                case 3:
                    SearchProduct();
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

    static void AddProduct()
    {
        Product newProduct = new Product();

        Console.Write("Nhập tên sản phẩm: ");
        newProduct.Name = Console.ReadLine();

        Console.Write("Nhập mô tả sản phẩm: ");
        newProduct.Description = Console.ReadLine();

        Console.Write("Nhập giá sản phẩm: ");
        newProduct.Price = decimal.Parse(Console.ReadLine());

        productList.Add(newProduct);
        Console.WriteLine("Đã thêm sản phẩm mới vào danh sách.");
    }

    static void DisplayProductList()
    {
        if (productList.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm trống.");
            return;
        }

        Console.WriteLine("Danh sách sản phẩm:");
        foreach (Product product in productList)
        {
            Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price:C}");
        }
    }

    static void SearchProduct()
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string searchName = Console.ReadLine();

        bool isFound = false;
        foreach (Product product in productList)
        {
            if (product.Name.Contains(searchName))
            {
                Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price:C}");
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine($"Không tìm thấy sản phẩm có tên '{searchName}'.");
        }
    }
}