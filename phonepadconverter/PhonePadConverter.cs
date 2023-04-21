using System;
using System.Collections.Generic;
using System.Text;

namespace phonepadconverter
{
    public class PhonePadConverter
    {
        private readonly Dictionary<char, string> buttonMap = new Dictionary<char, string>
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

        public string accumulator { get; private set; }
        private int offset;
        private char current;

        public PhonePadConverter()
        {
            accumulator = "";
            offset = 0;
            current = '\0';
        }

        public void PressButton(char buttonNumber)
        {
            if (current == '\0')
            {
                current = buttonNumber;
                offset++;
            }
            else
            {
                if (current == buttonNumber)
                {
                    offset++;
                    current = buttonNumber;
                }
                else
                {
                    string chars = buttonMap[current];
                    accumulator += chars[(offset + (offset > 0 ? -1 : 0)) % chars.Length];
                    current = buttonNumber;
                    offset = 1;
                }
            }
        }

        public void PressSendOrSpace()
        {
            if (current != '\0')
            {
                string chars = buttonMap[current];
                accumulator += chars[(offset + (offset > 0 ? -1 : 0)) % chars.Length];
            }
            offset = 0;
        }

        public void PressBackSpace()
        {
            current = '\0';
            offset = 0;
        }

        public void clear()
        {
            accumulator = "";
            current = '\0';
            offset = 0;
        }

    }
}
