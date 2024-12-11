internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Nhanvien nguyenVanA = new Truongphong("NV001", "Nguyen Van A", 1000, 1.5);
        Console.WriteLine($"Luong cua Nguyen Van A: {nguyenVanA.tinhLuong()}");

        // interface
        // chỉ có phương thức (hàm này không có thân hàm), không có hàm khởi tạo cũng như thuộc tính.

        // interface |NhanVien
        // {
        //  public void displayInfo();
        //  public double tinhLuong();
        // }

        // Animal
        Animal dog = new Animal("Dog");
        dog.eat();
        dog.sleep();

        // Bài tập về quản lý khách sạn.
        // abtract class: Room
        // - roomId: string
        // - roomName: string
        // - basePrice: double

        // class con:
        // - NormalRoom: Room
        // - LuxuryRoom: Room
        //      + extraService: string
        // - SuiteRoom:
        //      + extraService: string
        //      + premiumService: string
        
        // Iwifi


        // class Hotel

        Room normalRoom = new NormalRoom("01", "Normal Room 01", 400000);
        Room luxuryRoom = new LuxuryRoom("02", "Luxury Room 1", 400000, "Free breakfast");
        Room suiteRoom = new SuiteRooom("03", "Suite Room 01", 400000, "Free breakfast", "Free massage");

        Console.WriteLine($"Price of normal Room: {normalRoom.calculatePrice}");
        Console.WriteLine($"Price of luxury Room: {luxuryRoom.calculatePrice}");
        Console.WriteLine($"Price of suite Room: {suiteRoom.calculatePrice}");
    }
}