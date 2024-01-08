using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Day3
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();

            while(true)
            {
                string input = Console.ReadLine();

                if(string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            foreach (string s in lines)
            {

            }
        }
    }
}
