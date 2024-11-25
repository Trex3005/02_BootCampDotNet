using System.Diagnostics.Contracts;

class NhanVien
{
    public string MaNV;
    public string HoTen {get; set;}
    // mục đích dùng getter và setter để truy cập vào các thuộc tính private
    public string NgaySinh;
    public int Tuoi;
    public double luong;
    public string gioiTinh;
    public string MaQLNhom;

    public virtual double tinhLuong()
    {
        return 1000;
    }

}