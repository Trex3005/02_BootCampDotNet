internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Bài tập quản lý sản phẩm cửa hàng
        // Class:
        // - Product (class cha)
        // + productId: int
        // + productName: string
        // + price: double
        // + description: string

        // - Electronics(class con)
        // + warranty: int

        // - Fashion (class con)
        // + size: string (S, M, L, XL, XXL)
        
        // - productManager
        // + List<Product> products
        // + filePath: string
        // Product product = new Product(1, Laptop, 1000, newlaptop)
        // Product.sum(1,2);

        ProductManager productManager = new ProductManager();
        bool isRunning = true;
        while(isRunning)
        {
            Console.WriteLine("\n == Product Manager ==");
            Console.WriteLine("1. Add electronic");
            Console.WriteLine("2. Add fashion");
            Console.WriteLine("3. Display all products");
            Console.WriteLine("4. Search by name");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    productManager.addElectronic();
                    break;
                case 2:
                    Console.WriteLine("Add Fashion");
                    break;
                case 3:
                    productManager.displayAllproducts();
                    break;
                case 4:
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    productManager.searchByName(name);
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;    
            }
        }
    }
}