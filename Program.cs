using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a supposed to be a very long blog post blah blah blah.......";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 2, 4, 7, 34, 78};
            var max = numbers.Max();

            Console.WriteLine(max);
            Console.WriteLine(shortenedPost);
            Console.ReadLine();
        }
    }
}
