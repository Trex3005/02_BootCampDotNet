using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;


class Product
{
    private int productId;
    // interger: Auto_increament
    // string (uuid): 43789e2a-7dce-49cd-8364-ce89431015
    public int ProductId
    {
        get{return productId;}
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("ID must be greater than 0");
            }
            productId = value;
        }
    }
    
    // exception
    // 5 loại lỗi phổ biến
    // 1. lỗi logic và tham số (ArgumentException,....)
    // 2. Lỗi dữ liệu (FormatException,...
    // 3. Lỗi hệ thống
    // 4. Lỗi I/O và mạng
    // 5. Lỗi luồng và đa nhiệm

    private string productName;
    public string ProductName
    {
        get{return productName;}
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Product name must not be empty");
            }
            productName = value;
        }
    }

    private double price;

    public double Price
    {
        get{return price;}
        set{
            if(value < 0)
            {
                throw new ArgumentException("Price must be greater than 0");
            }
            price = value;
        }
    }

    private string description;
    public string Description
    {
        get{return description;}
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Diễn giải sản phẩm");
            }
            description = value;
        }
    }
    public Product(int productId, string productName, double price, string description)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Description = description;
    }

    public virtual void displayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }
}