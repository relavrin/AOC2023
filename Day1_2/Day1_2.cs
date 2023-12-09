using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    public class Day1_2
    {
        static void Main(string[] args)
        {
           
                List<string> lines = new List<string>();
                List<string> numbers = new List<string>();

                string sum = "";
                string check = "";
                string firstNum = "";
                string secondNum = "";

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
                    for (int i = 0; i < s.Length; i++)
                    {
                        char ch = s[i];

                        if (i == 0 && char.IsDigit(ch))
                        {
                            firstNum = ch.ToString();
                        }
                        else if (i == s.Length - 1 && char.IsDigit(ch))
                        {
                            secondNum = ch.ToString();
                        }
                    }

                    for (int i = 0; i < s.Length; i++)
                    {
                        char ch = s[i];
                        for (int j = i; j < i + 2; j++)
                        {
                            check += check.ToString();
                        }

                        if (firstNum == "" && check == "one" || check == "two" || check == "thr" || check == "fou" || check == "fiv" || check == "six" || check == "sev" || check == "eig" || check == "nin")
                        {
                            firstNum = check;
                        }
                        else if (secondNum == "" && check == "one" || check == "two" || check == "thr" || check == "fou" || check == "fiv" || check == "six" || check == "sev" || check == "eig" || check == "nin")
                        {
                            secondNum = check;
                        }
                    }

                    sum = firstNum + secondNum;
                    numbers.Add(sum);
                }

                Console.WriteLine(sum);
                Console.ReadLine();
            
        }
    }
}
