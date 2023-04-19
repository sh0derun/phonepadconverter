using System;
using System.Collections.Generic;
using System.Text;

namespace phonepadconverter
{
    class NumberKeyCommand : KeyCommand
    {
        private char number;

        public NumberKeyCommand(PhonePadConverter converter, char number): base(converter)
        {
            this.number = number;
        }

        public override void Execute()
        {
            converter.PressButton(number);
        }
    }
}
