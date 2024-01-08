using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    public class Day2_2
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<int> validID = new List<int>();

            string gameNum = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            foreach (string s in lines)
            {                            
                string number = "";
                int num = 0;
                string color = "";

                int numBlue = 0;
                int numRed = 0;
                int numGreen = 0;

                int multiply = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    char ch = s[i];

                    if (ch.Equals(':'))
                    {
                        for (int j = i; j < s.Length; j++)
                        {
                            char c = s[j];
                            if (char.IsDigit(c))
                            {
                                number += c.ToString();
                            }

                            if (char.IsLetter(c))
                            {
                                num = Convert.ToInt32(number);
                                color += c.ToString();

                            }

                            if (color == "blue")
                            {                               

                                if (numBlue == 0)
                                {
                                    numBlue = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else if (num > numBlue)
                                {
                                    numBlue = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else
                                {
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                            }
                            else if (color == "red")
                            {
                                if (numRed == 0)
                                {
                                    numRed = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else if(num > numRed) 
                                {
                                    numRed = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else
                                {
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                            }
                            else if (color == "green")
                            {
                                if (numGreen == 0)
                                {
                                    numGreen = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else if(num > numGreen)
                                {
                                    numGreen = num;
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                                else
                                {
                                    num = 0;
                                    color = "";
                                    number = "";
                                }
                            }
                        }
                        break;
                    }

                   

                }

                multiply = numBlue * numRed * numGreen;
                validID.Add(multiply);

            }
            int sum = 0;

            foreach (int i in validID)
            {
                sum += i;
            }
            Console.WriteLine("Total sum is: " + sum);
            Console.ReadLine();
        }
    }
    
}
