class Book
{
    public string bookId;
    public string bookName;
    public string author;
    public int price;

    public Book(string bookId, string bookName, string author, int price)
    {
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }
    // Phương thức hiển thị sách
    public void displayBook()
    {
        Console.WriteLine($"Book ID: {bookId}, Tên sách: {bookName}, Tác giả: {author}, Giá: {price}");
    }
}