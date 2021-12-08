using System;

namespace TwoUp
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}