using System;

namespace TwoUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Simulator simulator = new Simulator();
            simulator.RunSimulator();
            decimal doubleHead = simulator.doubleHead;
            decimal doubleTail = simulator.doubleTail;
            decimal numberOfOdds = simulator.numberOfOdds;
            var probabilityDoubleHeads = simulator.CalculateProbabilityDoubleHeads(doubleHead);
            var probabilityOfDoubleTails = simulator.CalculateProbabilityDoubleTails(doubleTail);
            var probabilityOfOdds = simulator.CalculateProbabilityOfOdds(numberOfOdds);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n\nDouble heads won {doubleHead} times and double tails won {doubleTail} times. Number of odds is {numberOfOdds}. ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nProbability of double heads is " + probabilityDoubleHeads + " %.");
            Console.WriteLine("Probability of double tails is " + probabilityOfDoubleTails + " %.");
            Console.WriteLine("Probability of odds is " + probabilityOfOdds + " %.");
            Console.ForegroundColor = ConsoleColor.Blue;
            var h=simulator.theLongestHead;
            Console.WriteLine("\nThe longest double head "+h);
            Console.ForegroundColor = ConsoleColor.Red;
            var t=simulator.theLongestTali;
            Console.WriteLine("The longest double tail "+t);
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}