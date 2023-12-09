using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2023
{
    public class Day1
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<string> numbers = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }


            foreach (string line in lines)
            {
                int result = HowManyNum(line);

                switch (result)
                {
                    case 1:
                        numbers.Add(OneNumber(line));
                        break;
                    case 2:
                        numbers.Add(TwoNumber(line));
                        break;
                    default:
                        numbers.Add(MoreThanTwo(line));
                        break;
                }
            }

            int finalNum = 0;           

            foreach  (string s in numbers)
            {
                int number = Convert.ToInt32(s);
                finalNum += number;
                Console.WriteLine(s);
            }

            Console.WriteLine(finalNum);
            Console.ReadLine();
        }

        
        private static int HowManyNum(string input)
        {
            int num = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if(char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }
        private static string OneNumber(string input)
        {
            int number = 0;
            string firstNum = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsDigit(ch) && number == 0)
                {
                    number++;

                    firstNum = ch.ToString();

                }           

            }
            string sum = firstNum + firstNum;
            return sum;

        }

        private static string TwoNumber(string input)
        {
            int number = 0;
            string firstNum = "";
            string secondNum = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsDigit(ch) && number == 0)
                {
                    number++;

                    firstNum = ch.ToString();

                }
                else if (char.IsDigit(ch) && number >= 1)
                {
                    secondNum = ch.ToString();
                }




            }
            string sum = firstNum + secondNum;
            return sum;
        }

        private static string MoreThanTwo(string input)
        {
            int number = 0;
            string firstNum = "";
            string secondNum = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsDigit(ch) && number == 0)
                {
                    number++;

                    firstNum = ch.ToString();

                }
                else if (char.IsDigit(ch) && number >= 1)
                {
                    secondNum = ch.ToString();
                }




            }
            string sum = firstNum + secondNum;
            return sum;
        }

    }
}
