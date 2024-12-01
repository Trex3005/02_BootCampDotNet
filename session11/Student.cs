class Student
{
    public string studentId;
    public string studentName;
    public int age;

    public Student(string studentId, string studentName, int age)
    {
        this.studentId = studentId;
        this.studentName = studentName;
        this.age = age;
    }
    // Phương thức hiển thị thông tin sinh viên

    public void displayInfor()
    {
        Console.WriteLine($"ID: {studentId}, Name: {studentName}, Age: {age} ");
    }
}