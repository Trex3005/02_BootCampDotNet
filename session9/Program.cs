internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // bản chất của OOP đó chính là gom nhóm các biến
        // các biến được gọi là các thuộc tính
        // chữ cái đầu tiên của class phải là in hoa
        BaiViet baiviet1 = new BaiViet();
        baiviet1.tieuDe = "Nhiệm vụ đặc biệt 100 ngày";
        baiviet1.noiDung = "Cuộc gọi nhiệm vụ";
        baiviet1.hinhAnh = "Hình ảnh 1";
        // Console.WriteLine($"Bài viết 1: {baiviet1.hinhAnh}, {baiviet1.noiDung}, {baiviet1.tieuDe}");
        baiviet1.xuatThongtin();

        Console.WriteLine("=============================");

        BaiViet baiviet2 = new BaiViet();
        baiviet2.tieuDe = "Chủ tịch nước gặp lãnh đạo Trung Quốc";
        baiviet2.noiDung = "Chủ tịch nước Lương Cường gặp TQ";
        baiviet2.hinhAnh = "Hình ảnh 2";
        // Console.WriteLine($"Bài viết 2: {baiviet2.hinhAnh}, {baiviet2.noiDung}, {baiviet2.tieuDe}");
        baiviet2.xuatThongtin();

        BaiViet baiviet3;
        baiviet3 = baiviet1;
        Console.WriteLine($"Kiểm tra: {baiviet3 == baiviet1}");
        
        BaiViet baiviet5 = new BaiViet();
        Console.WriteLine($"Giá trị mặc định: {baiviet5.noiDung}");
        // default value của các biến kiểu dữ liệu string là null
        // của interger là 0
        // của boolean là số 0 (0 và 1)

        // Bài tập nhập môn
        // tạo đối tượng học sinh (họ tên, tuổi, giới tính, email)
        // xuất thông tin học sinh

        HocSinh ttHocsinh = new HocSinh();
        
        ttHocsinh.nhapThongTinhocsinh();
        ttHocsinh.xuatThongTinhocsinh();
        
        // Bài 2:
        // Tạo lớp Reatangle (hình chữ nhật) với các thuộc tính:
        // length (chiều dài)
        // width (chiều rộng)
        // và các phương thức
        // nhập thông tin
        // Tính diện tích
        // Tính chu vi
    }
}