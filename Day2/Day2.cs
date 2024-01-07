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
                Console.WriteLine(convGameNum);

                string number = "";
                int num = 0;
                
                for (int i = 0; i < s.Length; i++)
                {
                    char ch = s[i];

                    if(char.IsDigit(ch))
                    {
                       number += ch.ToString(); 
                    }
                    if(ch.Equals(','))
                    {
                        break;
                    }
                }

             

                

            }

            Console.ReadLine();
        }
    }
}
