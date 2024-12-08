class Person
{
    private string name;
    private int age;

    // dùng property để truy cập từng thuộc tính
    public string Name
    {
        get{return name;}
        set
        {
            // thêm các logic kiểm tra giá trị trước khi
            // gán cho thuộc tính
            // check tên không được rỗng
            // hoặc check tên có độ dài tối thiểu là 2 ký tự
            if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Tên không hợp lệ");
            }
            name = value;
        }
    }
    public int Age
    {
        get{return age;}
        set
        {
            if(value < 0 || value > 150)
            {
            throw new ArgumentException("Tuổi không hợp lệ");
            }
            age = value;
        }
    }
    // khi đã define constructor mới, contructor mặc định sẽ không tự sinh ra
    public Person(string name, int age)
    {
        // gán giá trị cho thuộc tính thông qua setter (quan trọng)
        Name = name;
        Age = age;
    }
        
    public Person()
    {}
}