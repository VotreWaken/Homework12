using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play = new Play("Hello", "World", "Comedy", 1666);
            play.Show();
            play.Dispose();
            GC.Collect();
        }

        class Play
        {
            private string title;
            private string Author;
            private string genre;
            private int releaseYear;


            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string AuthorName
            {
                get { return Author; }
                set { Author = value; }
            }

            public string Genre
            {
                get { return genre; }
                set { genre = value; }
            }

            public int ReleaseYear
            {
                get { return releaseYear; }
                set { releaseYear = value; }
            }

            public Play(string title, string authorFullName, string genre, int releaseYear)
            {
                this.title = title;
                this.Author = authorFullName;
                this.genre = genre;
                this.releaseYear = releaseYear;
            }

            public void Show()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Genre: " + genre);
                Console.WriteLine("Year: " + releaseYear);
            }
            public void Dispose()
            {
                title = null;
                Author = null;
                genre = null;
                releaseYear = 0;
            }
            ~Play()
            {
                Console.WriteLine("Destructor");
                Dispose();
            }
        }
    }
}
