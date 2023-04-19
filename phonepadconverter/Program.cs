using System;
using System.Collections.Generic;

namespace phonepadconverter
{
    public class Program
    {

        public PhonePadConverter converter { get; private set; }

        public Program()
        {
            converter = new PhonePadConverter();
        }

        static void Main()
        {
            Console.WriteLine(new Program().OldPhonePad("8 88777444666*664#"));
            Console.Read();
        }

        public string OldPhonePad(string input)
        {
            KeyCommand command = null;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    command = new NumberKeyCommand(converter, c);
                }
                else if (c == '#' || c == ' ')
                {
                    command = new SendKeyCommand(converter);
                }
                else if (c == '*')
                {
                    command = new BackspaceKeyCommand(converter);
                }
                if(command != null)
                {
                    command.Execute();
                }
            }
            return converter.accumulator;
        }
    }
}