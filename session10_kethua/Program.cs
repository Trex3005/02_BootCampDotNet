internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // 4 tính chất trong OOP
        // - Tính kế thừa: class con kế thừa các thuộc tính (biến) và phương thức(hàm) của class cha
        // - Tính đóng gói:
        // - Tính trừu tượng:
        // - Tính đa hình:

        // BT mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý
        // Lập trình quản lý nhân sự trong công ty
        // Nhân viên: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương
        // tính lương: nhân viên = 1000
        // Trưởng nhóm: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm
        // tính lương: trường nhóm = 1000 + hệ số * 1000
        // Quản lý: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm, thư ký
        // tính lương: quản lý = 1000 + hệ số * 1000 + 500
        TruongNhom truongNhom = new TruongNhom();
        truongNhom.HoTen = "Nguyễn Văn Tèo";
        truongNhom.MaNV = "001";

        // Console.WriteLine($"Tên trưởng nhóm: {truongNhom.HoTen}");
        // Console.WriteLine($"Mã nhân viên: {truongNhom.MaNV}");
        Console.WriteLine(truongNhom.tinhLuong());

        // phạm vi truy cập của thuộc tính và phương thức.
        // public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài class.
        // private: class con và bên ngoài class không thể truy cập, chỉ có thể truy cập từ chính class đó.
        // protected: class con có thể truy cập các thuộc tính của class cha, nhưng bên ngoài class thì không thể truy cập.
        QuanLy quanLy = new QuanLy();
        quanLy.luong = 1000;
        // Console.WriteLine($"Lương quản lý là: {quanLy.luong}");
        Console.WriteLine(quanLy.tinhLuong());
        // C# check class QuanLy để tìm thuộc tính lương,
        // nếu không có check tiếp class cha (TruongNhom),
        // nếu không có check tiếp class cha của class TruongNhom (NhanVien)

        // lưu ý: override:
        // nếu class con không muốn các logic phương thức class cha
        // => có thể viết lại phương thức đó trong class con
        // nếu class con muốn dùng lại logic phương thức class cha
        // => có thể dùng từ khóa base.tenPhuongThuc() để gọi phương thwucs của class cha
    
        // BT ôn lại
        // - Sinh Viên, giảng viên, cán bộ trường học
        // viết chương trình quản lý những đối tượng trên
        // class: Người ID, tên, ngày sinh, giới tính, email.
        // sinh viên: ID, tên, ngày sinh, giới tính, email, lớp, điểm trung bình.
        // giảng viên: ID, tên, ngày sinh, giới tính, email, chyên ngành, học vị.
        // cán bộ: ID, tên, ngày sinh, giới tính, email, chức vụ, phòng ban.   
    
    
    }
}