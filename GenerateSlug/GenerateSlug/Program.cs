using System;

namespace GenerateSlug
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "what is the csharp programming language";
            Console.WriteLine(test.toSlug());
      }
    }
}
