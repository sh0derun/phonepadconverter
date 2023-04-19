using NUnit.Framework;
using phonepadconverter;

namespace PhonePadConverterTests
{
    public class PhonePadConverterTests
    {
        Program program = new Program();

        [TearDown]
        public void PhonePadConverter_TearDown()
        {
            program.converter.clear();
        }

        [Test]
        public void PhonePadConverter_Acceptance_Criteria1()
        {
            Assert.AreEqual(program.OldPhonePad("33#"), "E");
        }
        [Test]
        public void PhonePadConverter_Acceptance_Criteria2()
        {
            Assert.AreEqual(program.OldPhonePad("227*#"), "B");
        }
        [Test]
        public void PhonePadConverter_Acceptance_Criteria3()
        {
            Assert.AreEqual(program.OldPhonePad("4433555 555666#"), "HELLO");
        }
        [Test]
        public void PhonePadConverter_Acceptance_Criteria4()
        {
            Assert.AreEqual(program.OldPhonePad("8 88777444666*664#"), "TURING");
        }
    }
}