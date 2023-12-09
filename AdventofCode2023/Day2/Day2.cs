using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2023
{
    public class Day2
    {
       static void main(string[] args)
       {
            List<string> lines = new List<string>();
            List<string> numbers = new List<string>();

            while(true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            foreach  (string s in lines)
            {
                int result = HowManyNum(s);
                switch(result)
                {
                    case 1: 
                        OneNum(s);
                        break;
                    case 2:
                        TwoNum(s);
                        break;
                    default:
                        MoreThanOne(s);

                        break;

                }

            }
       }

        private static string MoreThanOne(string s)
        {

            return "";
        }

        private static string TwoNum(string s)
        {
            return "";
        }

        private static string OneNum(string s)
        {
            return "";
        }

        private static int HowManyNum(string input)
        {
            int num = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];


            }
            return 0;
        }
    }
}
