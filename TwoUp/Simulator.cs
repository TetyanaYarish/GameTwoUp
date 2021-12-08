using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoUp
{
    public class Simulator
    {
        RandomCoinGenerator grandomGenerator = new RandomCoinGenerator();
        public decimal doubleHead { get; set; }
        public decimal doubleTail { get; set; }
        public decimal numberOfOdds { get; set; }
        public int theLongestHead { get; set; }
        public int theLongestHead2 { get; set; }
        public int theLongestTali { get; set; }
        public int theLongestTail2 { get; set; }
        string head = "Head";
        string tail = "Tail";
        int numberOfRun;
        public void RunSimulator() //Function starts to run program, when user chooses number of spins
        {
            NumberOfSpins();
            for (int i = 1; i <= numberOfRun; i++)
            {
                string firstTry = grandomGenerator.OneUp();//First coin
                string secondTry = grandomGenerator.OneUp();//Second coin
                if (firstTry == head && secondTry == head)
                {
                    theLongestTail2 = 0;
                    theLongestHead2++;
                    if (theLongestHead < theLongestHead2)
                    {
                        theLongestHead++;
                    }
                    Console.Write($"Spin " + i + " of " + numberOfRun);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  \t" + firstTry + " + ");
                    Console.WriteLine(secondTry);
                    Console.ResetColor();
                    doubleHead++;
                }
                else if (firstTry == tail && secondTry == tail)
                {
                    theLongestHead2 = 0;
                    theLongestTail2++;
                    if (theLongestTali < theLongestTail2)
                    {
                        theLongestTali++;
                    }
                    Console.Write($"Spin " + i + " of " + numberOfRun);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  \t" + firstTry + " + ");
                    Console.WriteLine(secondTry);
                    doubleTail++;
                    Console.ResetColor();
                }
                else
                {
                    theLongestHead2 = 0; //reset number of double heads
                    theLongestTail2 = 0; //reset number of double tails
                    Console.Write($"Spin " + i + " of " + numberOfRun + "  \t" + firstTry + " + ");
                    Console.WriteLine(secondTry);
                    numberOfOdds = numberOfRun - doubleTail - doubleHead;
                }
            }
        }
        public void NumberOfSpins()// Read number of spins -input from user
        {
            Console.WriteLine("Please choose number of spins.");
            numberOfRun = Convert.ToInt32(Console.ReadLine());
        }
        public decimal CalculateProbabilityDoubleHeads(decimal InDoubleHead) //Calculate probability of double heads 
        {
            doubleHead = InDoubleHead;
            decimal probabilytyHeadWons = doubleHead / numberOfRun * 100;
            return probabilytyHeadWons;

        }
        public decimal CalculateProbabilityDoubleTails(decimal InDoubleTail)//Calculate probability of all double tails 
        {
            doubleTail = InDoubleTail;
            decimal probabilytyTailsWons = doubleTail / numberOfRun * 100;
            return probabilytyTailsWons;

        }
        public decimal CalculateProbabilityOfOdds(decimal InOffOdds)//Calculate probability of all odds 
        {
            numberOfOdds = InOffOdds;
            decimal probabilytyOdds = 100 - (CalculateProbabilityDoubleHeads(doubleHead) + CalculateProbabilityDoubleTails(doubleTail));
            return probabilytyOdds;

        }
    }
}
