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
        class FilmComparer : IComparer<Film>
        {
            public int Compare(Film x, Film y)
            {
                if (x.Profit != y.Profit)
                    return y.Profit.CompareTo(x.Profit);
                if (x.Year != y.Year)
                    return x.Year.CompareTo(y.Year);
                if (x.Income != y.Income)
                    return y.Income.CompareTo(x.Income);
                return x.Title.CompareTo(y.Title);
            }
        }

        static int CompareFilm(Film x, Film y)
        {
            if (x.Profit != y.Profit)
                return y.Profit.CompareTo(x.Profit);
            if (x.Year != y.Year)
                return x.Year.CompareTo(y.Year);
            if (x.Income != y.Income)
                return y.Income.CompareTo(x.Income);
            return x.Title.CompareTo(y.Title);
        }

        static Comparison<Film> Comp = CompareFilm;

        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("fucker");
            }
            Film[] film = new Film[n];
            for(int i = 0; i < n; ++i)
            {
                string[] line = Console.ReadLine().Split(';');
                try
                {
                    film[i] = new Film(line[0], int.Parse(line[1]), line[2], int.Parse(line[3]), int.Parse(line[4]));
                }
                catch(Exception)
                {
                    Console.WriteLine("idiot");
                }
            }

            //Array.Sort(film, new FilmComparer()); //Rendező osztály
            Array.Sort(film, Comp); //Comparison<> delegált
            Array.Sort(film, (x, y) => { return new FilmComparer().Compare(x, y); });
            foreach(Film f in film)
                Console.WriteLine(f);
        }
    }
}
