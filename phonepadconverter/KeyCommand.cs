using System;
using System.Collections.Generic;
using System.Text;

namespace phonepadconverter
{
    abstract class KeyCommand
    {
        protected PhonePadConverter converter;

        public KeyCommand(PhonePadConverter converter)
        {
            this.converter = converter;
        }

        public abstract void Execute();
    }
}
