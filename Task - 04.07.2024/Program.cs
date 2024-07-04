using Task___04._07._2024.DAL;
using Task___04._07._2024.Models;

namespace Task___04._07._2024;

internal class Program
{
    static void Main(string[] args)
    {
        //Genre genre = new Genre()
        //{
        //    Name = "SciFi"
        //};

        //Create(genre);

        //Update(5,genre);

        //DeleteGenre(1);

        //Console.WriteLine(GetGenreById(3));


        //var genres = GetAllGenres();
        //foreach (var item in genres)
        //{
        //    Console.WriteLine(item);
        //}

        Book book = new Book()
        {
            Name = "Death of Ivan Illyich",
            SalePrice = 5,
            CostPrice = 2,
            GenreId = 4
        };

        //Create(book);

        //Update(2, book);

        //Console.WriteLine(GetBookById(2));

        //var books = GetAllBooks();
        //foreach (var item in books)
        //{
        //    Console.WriteLine(item);
        //}

        //DeleteBook(2);
    }

    static void Create(Genre genre)
    {
        AppDbContext dbContext = new AppDbContext();
        dbContext.Genres.Add(genre);
        dbContext.SaveChanges();
    }
    static void Create(Book book)
    {
        AppDbContext dbContext = new AppDbContext();
        dbContext.Books.Add(book);
        dbContext.SaveChanges();
    }


    static void Update(int id, Genre genre)
    {
        AppDbContext dbContext = new AppDbContext();
        var existGenre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
        if (existGenre is null)
        {
            throw new NullReferenceException();
        }

        existGenre.Name = genre.Name;
        dbContext.SaveChanges();
    }
    static void Update(int id, Book book)
    {
        AppDbContext dbContext = new AppDbContext();
        var existBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
        if (existBook is null)
        {
            throw new NullReferenceException();
        }

        existBook.Name = book.Name;
        existBook.CostPrice = book.CostPrice;
        existBook.SalePrice = book.SalePrice;
        existBook.GenreId = book.GenreId;
        dbContext.SaveChanges();
    }

    static Genre GetGenreById(int id)
    {
        AppDbContext dbContext = new AppDbContext();
        Genre wantedGenre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
        if (wantedGenre is null)
        {
            throw new NullReferenceException();
        }

        return wantedGenre;
    }
    static Book GetBookById(int id)
    {
        AppDbContext dbContext = new AppDbContext();
        Book wantedBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
        if (wantedBook is null)
        {
            throw new NullReferenceException();
        }

        return wantedBook;
    }

    static List<Genre> GetAllGenres()
    {
        AppDbContext dbContext = new AppDbContext();
        return dbContext.Genres.ToList();
    }
    static List<Book> GetAllBooks()
    {
        AppDbContext dbContext = new AppDbContext();
        return dbContext.Books.ToList();
    }




    static void DeleteGenre(int id)
    {
        AppDbContext dbContext = new AppDbContext();
        Genre wantedGenre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
        if (wantedGenre is null)
        {
            throw new NullReferenceException();
        }

        dbContext.Genres.Remove(wantedGenre);
        dbContext.SaveChanges();
    }

    static void DeleteBook(int id)
    {
        AppDbContext dbContext = new AppDbContext();
        Book wantedBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
        if (wantedBook is null)
        {
            throw new NullReferenceException();
        }

        dbContext.Books.Remove(wantedBook);
        dbContext.SaveChanges();
    }
}
