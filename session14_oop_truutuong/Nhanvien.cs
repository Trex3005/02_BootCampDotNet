using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

abstract class Nhanvien
{
    private string maNV;
    public string MaNV
    {
        get{return maNV;}
        set{maNV = value;}
    }

    private string hoTen;
    public string HoTen
    {
        get{return hoTen;}
        set{hoTen = value;}
    }

    private double luongCoban;

    public double LuongCoban
    {
        get{return luongCoban;}
        set{luongCoban = value;}
    }

    public Nhanvien(string maNV, string hoTen, double luongCoban)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
        this.luongCoban = luongCoban;
    }

    public void chamCong()
    {
        Console.WriteLine("Cham cong");
    }

    // hàm abstract này không có thân hàm
    public abstract double tinhLuong();


}