using Task___04._07._2024.DAL;
using Task___04._07._2024.Models;

namespace Task___04._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Genre genre = new Genre()
            {
                Name = "Sci-Fi"
            };

            //Create(genre);
            //Delete(1);
            //Console.WriteLine(GetById(3));
            //var genres = GetAll();
            //foreach (var item in genres)
            //{
            //    Console.WriteLine(item);
            //}

        }

        static void Create(Genre genre)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.Genres.Add(genre);
            dbContext.SaveChanges();
        }

        static Genre GetById(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            Genre wantedGenre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (wantedGenre is null)
            {
                throw new NullReferenceException();
            }

            return wantedGenre;
        }


        static List<Genre> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Genres.ToList();
        }


        static void Delete(int id)
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
    }
}
