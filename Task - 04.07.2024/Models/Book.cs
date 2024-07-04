using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task___04._07._2024.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
