using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string Category;//string, field, object, variable
        private string Title;
        public Movie(string Title, string Category)
        {
            this.Title=Title; //doing this means we are required for the main method to ask for userInput (unless we default it) to put in.
            this.Category = Category;
            //Console.WriteLine("Movies in the category "+ Category + ":" + Title);
        }
        public bool MovieMatch (string Category)
        {
            if (Category == this.Category)//think of this.Category equal to film on program.cs
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintMovieName()
        {
            Console.WriteLine(this.Title);
        }
        
        
    }
}

