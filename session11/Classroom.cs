class Classroom
{
    public string classId;
    public string className;
    public List<Student> students;

    // contructor
    public Classroom(string classId, string className)
    {
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();

    }
    // phương thức thêm sinh viên vào lớp
    public void addStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }
    // phương thức hiển thị danh sách sinh viên trong lớp
    public void showStudent()
    {
        Console.WriteLine($"\n -----Students in class {className}----");
        foreach(Student student in students)// students là mảng, Student đầu tiên là 1 kiểu dữ liệu kiểu class
        {
            student.displayInfor();
        }
    }
    // phương thức tìm kiếm sinh viên theo mã sinh viên
    public void findStudentbyStudentID(string studentId)
    {
        // C1: dùng vòng lặp
        foreach (Student student in students)
        {
            if(student.studentId == studentId)
            {
                student.displayInfor();
                return;
            }
        }
        Console.WriteLine($"Student with ID {studentId} not found in class {className}");
    }

}