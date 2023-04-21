using System;
using System.Collections.Generic;
using System.Text;

namespace phonepadconverter
{
    class BackspaceKeyCommand : KeyCommand
    {
        public BackspaceKeyCommand(PhonePadConverter converter) : base(converter) { }

        public override void Execute()
        {
            converter.PressBackSpace();
        }
    }
}
