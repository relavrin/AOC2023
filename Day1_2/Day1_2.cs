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
                firstNum = "";
                secondNum = "";
                 

                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        for (int j = i; j < i + 3 && j <= s.Length-1; j++)
                        {
                            char ch = s[j];
                            if(char.IsDigit(ch)) 
                            {
                                firstNum = ch.ToString();
                                break;
                            }
                            check += ch.ToString();
                        }

                        
                        if(check == "one" || check == "two" || check == "thr" || check == "fou" || check == "fiv" || check == "six" || check == "sev" || check == "eig" || check == "nin")
                        {
                                firstNum = check;
                                break;
                        
                        }
                        if (!string.IsNullOrEmpty(firstNum))
                        {
                            break;
                        }
                        
                        check = "";
                    }
                    check = "";
                    string flipped = "";
                for (int i = s.Length - 1; i > 0; i--)
                {
                    for (int j = i; j > i - 3 && j >= 0; j--)
                    {
                        char ch = s[j];
                        if (char.IsDigit(ch))
                        {
                            secondNum = ch.ToString();
                            break;
                        }
                        check += ch.ToString();
                    }

                    flipped = Flip(check);
                   
                        if (flipped == "one" || flipped == "two" || flipped == "thr" || flipped == "fou" || flipped == "fiv" || flipped == "six" || flipped == "sev" || flipped == "eig" || flipped == "nin")
                        {
                            secondNum = flipped;
                            break;
                        }
                    if (!string.IsNullOrEmpty(secondNum))
                    {
                        break;
                    }
                    check = "";
                    flipped = "";
                }

                check = "";
                    switch(firstNum)
                    {
                        case "one":
                            firstNum = "1";
                            break;
                        case "two":
                            firstNum = "2";
                            break;
                        case "thr":
                            firstNum = "3";
                            break;
                        case "fou":
                            firstNum = "4";
                            break;
                        case "fiv":
                            firstNum = "5";
                            break;
                        case "six":
                            firstNum = "6";
                            break;
                        case "sev":
                            firstNum = "7";
                            break;
                        case "eig":
                            firstNum = "8";
                            break;
                        case "nin":
                            firstNum = "9";
                            break;
                    }

                    switch (secondNum)
                    {
                        case "one":
                        secondNum = "1";
                            break;
                        case "two":
                        secondNum = "2";
                            break;
                        case "thr":
                        secondNum = "3";
                            break;
                        case "fou":
                        secondNum = "4";
                            break;
                        case "fiv":
                        secondNum = "5";
                            break;
                        case "six":
                        secondNum = "6";
                            break;
                        case "sev":
                        secondNum = "7";
                            break;
                        case "eig":
                        secondNum = "8";
                            break;
                        case "nin":
                        secondNum = "9";
                            break;
                    }
                    sum = firstNum + secondNum;
                    numbers.Add(sum);
                    sum = "";
                }

            int totalNumber = 0;

                foreach(string s in numbers)
                {
                    
                   int number = Convert.ToInt32(s);
                   Console.WriteLine(number);

                   totalNumber += number;
                }

            Console.WriteLine("Total number is: " + totalNumber);
            Console.ReadLine();
            

        }

        private static string Flip(string check)
        {
            char[] chArr = check.ToCharArray();
            Array.Reverse(chArr);
            return new string(chArr);
        }
    }
}
