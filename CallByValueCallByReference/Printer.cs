namespace CallByValueCallByReference;

public class Printer
{
    // Paper is of type struct
    public void Print(Paper paper)
    {
        paper.TimesPrinted++;
    }
    
    // Book is of type class
    public void Print(Book book)
    {
        book.TimesPrinted++;
    }
}