using AdvancedCSharpFeatures.LINQ;
using AdvancedCSharpFeatures.Threading;
using System;

namespace AdvancedCSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            new LinqDemo();

            new ThreadingDemo();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
