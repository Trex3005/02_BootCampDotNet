using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    
    {
        #region Bài 1: Quản lý lớp học
        // Console.WriteLine("Hello, World!");
        
        // // B1: Quản lý lớp học
        // // 1. Lớp học
        // // Tạo lớp Classrooom để quản lý lớp học
        // // classId: mã lớp học
        // // className: tên lớp học
        // // danh sách sinh viên trong lớp
        // // 2. Sinh Viên
        // // studentId: mã sinh viên
        // // studentName: tên sinh viên
        // // age: tuổi
        // // 3. Yêu cầu chức năng
        // // Thêm sinh viên vào lớp
        // // Hiển thị danh sách sinh viên trong lớp
        // // Tìm kiếm sinh viên theo mã sinh viên

        // // tạo lớp học
        // Classroom classroom = new Classroom("C02", "Dotnet02");
        // // tạo menu quản lý sinh viên
        // // 1. Thêm sinh viên
        // // 2. Hiển thị danh sách sinh viên
        // // 3. Tìm kiếm sinh viên
        // // 4. Thoát

        // while(true)
        // {
        //     Console.WriteLine("\n----Classrooom Management----");
        //     Console.WriteLine("1. Add student");
        //     Console.WriteLine("2. Show students");
        //     Console.WriteLine("3. Find student by student ID");
        //     Console.WriteLine("4. Exit");
        //     Console.WriteLine("Please enter your choice (1-4)");
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //     switch(choice)
        //     {
        //         case 1:
        //             //Thêm sinh viên
        //             Console.WriteLine("Enter Student ID");
        //             string? studentId = Console.ReadLine();
        //             Console.WriteLine("Entrer Student Name");
        //             string? studentName = Console.ReadLine();
        //             Console.WriteLine("Enter Student Age");
        //             int age = Convert.ToInt32(Console.ReadLine());

        //             Student student = new Student(studentId, studentName, age);

        //             classroom.addStudent(student);

        //             // lưu danh sách sinh viên vào json
        //             // chuyển danh sách sinh viên thành json
                    
        //         break;

        //         case 2:
        //             // Hiển thị danh sách sinh viên
        //             classroom.showStudent();
        //         break;

        //         case 3:
        //             // Tìm kiếm sinh viên theo mã sinh viên
        //             Console.WriteLine("Entrer student ID to find:");
        //             string id = Console.ReadLine();
        //             if(id == null)
        //             {
        //                 Console.WriteLine("Student ID is required");
        //             }
        //             classroom.findStudentbyStudentID(id);
        //             break;
        //         case 4:
        //             // Thoát
        //             return;
        //         default:
        //             Console.WriteLine("Invalid Choice. Please enter 1-4");
        //             break;
        //     }
        // }
        #endregion
    
        #region Bài 2: Quản lý thư viện
        // 1. Tạo class Book để quản lý sách
        // -bookId: mã sách
        // -bookName: tên sách
        // -author: tác giả
        // -price: giá sách
        // -----------------
        // 2. Tạo class Library để quản lý thư viện
        // -libraryId: mã thư viện
        // -libraryName: tên thư viện
        // -danh sách sách trong thư viện
        // ------------------------
        // 3. Yêu cầu chức năng
        // -Thêm sách vào thư viện (làm ở class Library)
        // -Hiển thị danh sách sách trong thư viện (hiển thị sách thì ở class Book, trong thư viện thì ở class Library)
        // -Tìm sách theo mã sách (làm ở class Library)
        // -Thoát
        Library library = new Library("C03", "Dotnet02");
        while(true)
        {
            Console.WriteLine("\n----Library Management----");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show book");
            Console.WriteLine("3. Find book by ID");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please enter your choice (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    //Thêm book
                    Console.WriteLine("Enter Book ID");
                    string? bookId = Console.ReadLine();
                    Console.WriteLine("Entrer Book Name");
                    string? bookName = Console.ReadLine();
                    Console.WriteLine("Entrer Author Name");
                    string? author = Console.ReadLine();
                    Console.WriteLine("Enter Book Price");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(bookId, bookName, author, price);

                    library.addBook(book);

                    
                break;

                case 2:
                    // Hiển thị sách trong thư viện
                    library.showBook();
                break;

                case 3:
                    // Tìm kiếm sinh viên theo mã sinh viên
                    Console.WriteLine("Entrer book ID to find:");
                    string bookId = Console.ReadLine();
                    if(bookId == null)
                    {
                        Console.WriteLine("book ID is required");
                    }
                    library.findBookid(bookId);
                    break;
                case 4:
                    // Thoát
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Please enter 1-4");
                    break;
            }
        }
        #endregion
    }
}