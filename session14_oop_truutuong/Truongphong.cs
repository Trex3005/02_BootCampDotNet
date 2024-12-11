class Truongphong : Nhanvien
{
    private double heSoLuong;
    public double HeSoLuong
    {
        get{return heSoLuong;}
        set{heSoLuong = value;}
    }

    public Truongphong(string maNV, string hoTen, double luongCoban, double heSoLuong) : base(maNV, hoTen, luongCoban)
    {
        this.heSoLuong = heSoLuong;
    }

    public override double tinhLuong()
    {
        this.LuongCoban = this.LuongCoban * HeSoLuong;
        return this.LuongCoban;
    }
}