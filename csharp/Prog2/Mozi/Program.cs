using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi
{
    class Film : IComparable<Film>
    {
        public Film(string title, int year, string director, int budget, int income)
        {
            Title = title;
            Year = year;
            Director = director;
            Budget = budget;
            Income = income;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int Budget { get; set; }
        public int Income { get; set; }
        public int Profit { get { return this.Income - this.Budget; } }

        public override string ToString()
        {
            return this.Title;
        }

        public int CompareTo(Film other)
        {
            if (this.Profit != other.Profit)
                return other.Profit.CompareTo(this.Profit);
            if (this.Year != other.Year)
                return this.Year.CompareTo(other.Year);
            if (this.Income != other.Income)
                return other.Income.CompareTo(this.Income);
            return this.Title.CompareTo(other.Title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Film[] film = new Film[n];
            for(int i = 0; i < n; ++i)
            {
                string[] line = Console.ReadLine().Split(';');
                film[i] = new Film(line[0], int.Parse(line[1]), line[2], int.Parse(line[3]), int.Parse(line[4]));
            }

            Array.Sort(film);
            foreach(Film f in film)
                Console.WriteLine(f);
        }
    }
}
