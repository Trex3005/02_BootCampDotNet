class SanPham
{
    public string maSanpham;
    public string tenSanpham;
    public double giaBan;
    public int soLuong;
    public void nhapThongtin()
    {
        Console.WriteLine("Nhập mã sản phẩm: ");
        maSanpham = Console.ReadLine();

        Console.WriteLine("Nhập tên sản phẩm:");
        tenSanpham = Console.ReadLine();

        Console.WriteLine("Nhập giá bán: ");
        giaBan = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập số lượng: ");
        soLuong = Convert.ToInt32(Console.ReadLine());

    }

    public void xuatThongtin()
    {
        Console.WriteLine($"Mã sản phẩm: {maSanpham}");
        Console.WriteLine($"Tên sản phẩm: {tenSanpham}");
        Console.WriteLine($"Giá bán sản phẩm: {giaBan}");
        Console.WriteLine($"Số lượng sản phẩm: {soLuong}");
    }



}