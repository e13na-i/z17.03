using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z17._03
{
    internal class Program
    {
        static bool IsValidBrackets(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            foreach (char c in s)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        static void Main()
        {
            string input= Console.ReadLine();

            Console.WriteLine(IsValidBrackets(input));
        }
    }
}
