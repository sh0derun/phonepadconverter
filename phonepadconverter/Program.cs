using System;
using System.Collections.Generic;

namespace phonepadconverter
{
    public class Program
    {

        private static readonly Dictionary<char, string> buttonMap = new Dictionary<char, string>{
                { '0', " " },
                { '2', "ABC" },
                { '3', "DEF" },
                { '4', "GHI" },
                { '5', "JKL" },
                { '6', "MNO" },
                { '7', "PQRS" },
                { '8', "TUV" },
                { '9', "WXYZ" }
            };

        static void Main()
        {
            Console.Write("Enter the input numbers from the old phone pad :");
            string input = Console.ReadLine();
            Console.WriteLine(Program.OldPhonePad(input));//"7777255562*2207777255562*22*2#"));
            Console.Read();
        }

        public static string OldPhonePad(string input)
        {

            int offset = 0;
            string acc = "";
            char current = '\0';

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    if (current == '\0')
                    {
                        current = c;
                        offset++;
                    }
                    else
                    {
                        if (current == c)
                        {
                            offset++;
                            current = c;
                        }
                        else
                        {
                            string chars = buttonMap[current];
                            acc += chars[(offset + (offset > 0 ? -1 : 0)) % chars.Length];
                            current = c;
                            offset = 1;
                        }
                    }
                }
                else if (c == '#' || c == ' ')
                {
                    if (current != '\0')
                    {
                        string chars = buttonMap[current];
                        acc += chars[(offset + (offset > 0 ? -1 : 0)) % chars.Length];
                    }
                    offset = 0;
                }
                else if (c == '*')
                {
                    current = '\0';
                    offset = 0;
                }
            }

            return acc;
        }
    }
}