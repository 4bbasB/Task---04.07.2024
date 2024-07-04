namespace Task___04._07._2024.Models;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }
}
