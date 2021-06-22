using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {


            { // User to enter floor width
                Console.WriteLine("Enter floor width");
                int InchWidth = Convert.ToInt32(Console.ReadLine());

                // user to enter floor lenght 
                Console.WriteLine("Enter floor lenght");
                int InchLength = Convert.ToInt32(Console.ReadLine());

                // cost per 1 unit 
                decimal totalwidthinFeet = (InchWidth / 12);
                decimal totalLengthinFeet = (InchLength / 12);

                var totalArea = totalLengthinFeet * totalwidthinFeet;

                //oh this is HashCode that doesnt work

                Console.WriteLine(totalArea);
                

                Console.ReadLine();

                Console.ReadKey();

            }
        }

    }
}
