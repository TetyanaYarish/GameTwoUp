using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoUp
{
   
        public class RandomCoinGenerator
        {
            public List<string> coinSide = new List<string> { "Tail", "Head"};

            public string OneUp()//Function, which return randomly side from coinSide
            {
                int num = coinSide.Count();
                string value = coinSide[new Random().Next(0, num)];
                return value;
            }
        }
}
