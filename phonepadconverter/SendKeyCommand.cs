using System;
using System.Collections.Generic;
using System.Text;

namespace phonepadconverter
{
    class SendKeyCommand : KeyCommand
    {
        public SendKeyCommand(PhonePadConverter converter) : base(converter){}

        public override void Execute()
        {
            converter.PressSendOrSpace();
        }
    }
}
