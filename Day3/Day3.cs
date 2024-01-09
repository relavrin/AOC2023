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
            List<int> numbers = new List<int>();

            while(true)
            {
                string input = Console.ReadLine();

                if(string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            int num = 0;
            string number = "";
            int sum = 0;
            string symbol = "";

            foreach (string s in lines)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    char ch = s[i];

                    if(char.IsDigit(ch))
                    {
                        number += ch.ToString();

                    }

                    if (ch.Equals('.'))
                    {
                        if (number == "")
                        {

                        }
                        else
                        {
                            num = Convert.ToInt32(number);
                            number = "";
                            sum += num;
                        }
                    }


                }

                
            }

           
            Console.WriteLine("Total sum: " + sum);
            Console.ReadLine();
        }
    }
}
