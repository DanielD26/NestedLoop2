using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();
            // int counter = 0;

            // while (counter < 10) {
    

            //     int counter2 = counter;

            //     while (counter2 < 5) {
            //         Console.Write(name);
            //         counter2 = counter2 + 1;
            //     }
            //     Console.WriteLine();
            //     counter = counter + 1;
            // }

            // Console.WriteLine("Goodbye "+ name);

            // int counter = 0;
            
            // while (counter < 10) {
            //     int counter2 = counter;

            //     while (counter2 < 5) {
            //         Console.Write('x');
            //         counter2++;
            //     }

            //     Console.WriteLine();
            //     counter++;
            // }

            // Console.WriteLine("Enter how many X's to start: ");
            // string getStart = Console.ReadLine();
            // int start = int.Parse(getStart);

            // int counter = 0;
            // while(counter < start*2) {
            //     int counter2 = counter;

            //     while(counter2 < start) {
            //         Console.Write('x');
            //         counter2++;
            //     }

            //     Console.WriteLine();
            //     counter++;
            // }

            // int counter = 0;
            // while (counter < 10) {
            //     int counter2 = 0;
            //     counter++;
            //     while (counter2 < counter) {
            //         Console.Write('x');
            //         counter2++;
            //     }
            //     Console.WriteLine();
            // }

            Console.Write("Enter how many lines of X's you want: ");
            string getLines = Console.ReadLine();
            int lines = int.Parse(getLines);

            int counter = 0;
            while (counter < lines) {
                int counter2 = 0;
                counter++;
                while (counter2 < counter) {
                    Console.Write('x');
                    counter2++;
                }
                Console.WriteLine();
            }
        }
    }
}