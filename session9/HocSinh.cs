class HocSinh
{
    public string hoTen;
    public int tuoi;

    public string gioiTinh;

    public string email;
    public void nhapThongTinhocsinh()
    {
        Console.WriteLine("Thông tin học sinh:");
        
        Console.WriteLine("Họ tên: ");
        hoTen = Console.ReadLine();
                
        Console.WriteLine("Tuổi: ");
        tuoi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Giới tính: ");
        gioiTinh = Console.ReadLine();

        Console.WriteLine("Email: ");
        email = Console.ReadLine();
    }

    public void xuatThongTinhocsinh()
    {
        Console.WriteLine("Thông tin học sinh");
        Console.WriteLine($"Họ và tên: {hoTen}");
        Console.WriteLine($"Tuổi: {tuoi}");
        Console.WriteLine($"Giới tính: {gioiTinh}");
        Console.WriteLine($"Email: {email}");

    }
}