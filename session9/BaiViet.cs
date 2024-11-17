class BaiViet 
{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;

    // default khi khởi tạo đối tượng thì C# sẽ gọi hàm khởi tạo (constructor) mặc định
    // hàm khởi tạo này sẽ tạo giá trị mặc định cho các thuộc tính
    // cú pháp <tên class>(){}
    public BaiViet()
    {
        Console.WriteLine("Đây là hàm khởi tạo");
    } // Khởi tạo hàm constructor
      // Có 2 loại hàm constructor: có tham số và không có tham số
      // Lưu ý: trong class chỉ có 1 trong 2 loại hàm contructor xuất hiện.
      // contructor trong class

    public BaiViet(string tieuDe, string noiDung, string hinhAnh)
    {
        this.tieuDe = tieuDe;
        this.noiDung = noiDung;
        this.hinhAnh = hinhAnh;
    }

    public BaiViet(BaiViet other)
    {
        this.tieuDe = other.tieuDe;
        this.noiDung = other.noiDung;
        this.hinhAnh = other.hinhAnh;
    }

    public void xuatThongtin()
    {
        Console.WriteLine("Thông tin bài viết là:");
        Console.WriteLine($"Tiêu đề: {tieuDe}");
        Console.WriteLine($"Nội dung: {noiDung}");
        Console.WriteLine($"Hình ảnh: {hinhAnh}");
    }
}