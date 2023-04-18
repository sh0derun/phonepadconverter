using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        Dictionary<char, string> buttonMap = new Dictionary<char, string>
        {
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

        Console.WriteLine(OldPhonePad(buttonMap, "4433555 555666#"));
        Console.WriteLine(OldPhonePad(buttonMap, "33#"));
        Console.WriteLine(OldPhonePad(buttonMap, "227*#"));
        Console.WriteLine(OldPhonePad(buttonMap, "8 88777444666*664#"));
        Console.WriteLine(OldPhonePad(buttonMap, "7777255562*2207777255562*22*2#"));
        Console.Read();
    }

    private static string OldPhonePad(Dictionary<char, string> buttonMap, string input)
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
                if(current != '\0')
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