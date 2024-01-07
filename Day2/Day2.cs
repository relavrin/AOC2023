using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    public class Day2
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<int> validID = new List<int>();

            string gameNum = "";

            while(true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            foreach(string s in lines)
            {
                for (int i = 0; i < s.Length; i++) 
                {
                    char ch = s[i];

                    if(char.IsDigit(ch))
                    {
                        gameNum += ch.ToString();
                        
                    }

                    
                    if(ch.Equals(':'))
                    {
                        break;
                    }
                }
                int convGameNum = Convert.ToInt32(gameNum);
                gameNum = "";

                string number = "";
                int num = 0;
                string color = "";
                
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
                                if (num > 14)
                                {
                                    
                                    convGameNum = 0;
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
                                if (num > 12)
                                {
                                    
                                    convGameNum = 0;
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
                                if (num > 13)
                                {
                                    
                                    convGameNum = 0;
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
                    }
                    
                    if(convGameNum == 0)
                    {
                        break;
                    }
                    
                }

                if(convGameNum == 0)
                {

                }
                else
                {
                    validID.Add(convGameNum);
                    Console.WriteLine(convGameNum);

                }


            }
            int sum = 0;

            foreach(int i in validID)
            {
                sum += i;
            }
            Console.WriteLine("Total sum is: " + sum);
            Console.ReadLine();
        }
    }
}
