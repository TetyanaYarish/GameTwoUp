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
        // public List<int> theLongestTail=new List<int>();
        public int theLongestHead { get; set; }
        private int theLongestHead21;
        public bool TailLeader { get; set; }
        public bool HeadLeader { get; set; }
        public int theLongestHead2 { get { return theLongestHead21; } set { theLongestHead21 = value; } }
        public int theLongestTail { get; set; }
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
                    HeadLeader = true;
                   // 
                    Console.Write($"Spin " + i + " of " + numberOfRun);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  \t" + firstTry + " + ");
                    Console.WriteLine(secondTry);
                    Console.ResetColor();
                    if (theLongestHead==0 || theLongestHead <= theLongestHead2 && TailLeader==true)
                    {
                        TailLeader = false;
                        theLongestHead ++;
                        theLongestHead21 = theLongestHead;
                       if (theLongestHead < theLongestHead2)
                        {
                            theLongestHead =theLongestHead+theLongestHead2;
                            //theLongestHead21 = theLongestHead2;
                            //if (theLongestHead2<theLongestHead21)
                            //{
                            //    theLongestHead21++;
                            //}
                        }
                        // theLongestHead = theLongestHead2;
                    }
                    else
                    {
                        theLongestHead++;
                    }

                    doubleHead++;
                }
                else if (firstTry == tail && secondTry == tail)
                {
                   // HeadLeader = false;
                    TailLeader = true;
                    Console.Write($"Spin " + i + " of " + numberOfRun);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  \t" + firstTry + " + ");
                    Console.WriteLine(secondTry);
                    theLongestTail = theLongestTail + 1;
                    doubleTail++;
                    Console.ResetColor();
                }
                else
                {
                    //    theLongestTail = 0;
                    //    theLongestHead = 0;
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
