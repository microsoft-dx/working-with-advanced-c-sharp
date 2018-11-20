using System;   
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharpFeatures.Threading
{
    public class ThreadingDemo
    {
        // We can Use the Task.Delay() method in order to wait for a given time
        private async Task<int> GetIntAfter(int numberOfSeconds, int desiredNumber)
        {
            await Task.Delay(numberOfSeconds);

            return desiredNumber;
        }

        // We have Parallel for and Parallel foreach, let's use them
        private void ShowNumbersWithParallelFor(int numberFrom, int numberTo)
        {
            Parallel.For(numberFrom, numberTo, (i) => {
                Console.WriteLine(GetIntAfter(5, 5).Result);
            });

            Console.WriteLine("Parallel For is DONE!");
        }

        // Given The example let's use the foreach and await operators
        private void ShowNumbersWithParallelForEach(int numberFrom, int numberTo)
        {
            // To be done
            // Check the Foreach syntax
            // Gather What we need, use LINQ


            Console.WriteLine("Parallel ForEach is DONE!");
        }

        private async void UseBariers()
        {
            // We have a barrier in C# that lets us stop the thread from going on if they are not all done
            Barrier waitAfter = new Barrier(0);

            // Use Parallel.Invoke and Call the 2 paralle fors
            // You should also check the Barrier Counter, good luck

            await Task.Delay(5);


            Console.WriteLine("I should be after the 2 fors, if all is good.");
        }

        public ThreadingDemo()
        {
            // We don't need await if we have async void
            UseBariers();
        }
    }
}
