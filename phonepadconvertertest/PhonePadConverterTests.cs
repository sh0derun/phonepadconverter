using NUnit.Framework;
using phonepadconverter;

namespace PhonePadConverterTests
{
    public class PhonePadConverterTests
    {
        [Test]
        public void PhonePadConverter_Acceptance_Criteria()
        {
            Assert.AreEqual(Program.OldPhonePad("33#"), "E");
            Assert.AreEqual(Program.OldPhonePad("227*#"), "B");
            Assert.AreEqual(Program.OldPhonePad("4433555 555666#"), "HELLO");
            Assert.AreEqual(Program.OldPhonePad("8 88777444666*664#"), "TURING");
        }
    }
}