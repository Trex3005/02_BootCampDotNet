class Library
{
    public string libraryId;
    public string libraryName;
    public List<Book> books;

    // Constructor
    public Library(string libraryId, string libraryName)
    {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = new List<Book>();
    }

    // phương thức thêm sách vào thư viện
    public void addBook(Book book)
    {
        books.Add(book);
    }
    // phương thức hiển thị danh sách sách trong thư viện
    public void showBook()
    {
        foreach(Book book in books)
        {
            book.displayBook();
        }
    }
    // phương thức tìm kiếm sinh viên theo mã sinh viên
    public void findBookid(string bookId)
    {
        // C1: dùng vòng lặp
        foreach (Book book in books)
        {
            if(book.bookId == bookId)
            {
                book.displayBook();
                return;
            }
        }
        Console.WriteLine($"Book with ID {bookId} not found in library {libraryName}");
    }

}