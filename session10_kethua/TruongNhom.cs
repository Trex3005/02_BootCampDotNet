using System.Reflection.Metadata.Ecma335;

class TruongNhom : NhanVien
{
    public string MaQLNhom;

    public string getMaNV()
    {
        return this.MaNV;
    }

    public override double tinhLuong()
    {
        double luongCoBan = base.tinhLuong();
        return luongCoBan + 1.5*luongCoBan;
    }
}
