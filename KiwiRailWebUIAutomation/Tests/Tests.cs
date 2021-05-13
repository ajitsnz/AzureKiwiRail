using NUnit.Framework;

namespace KiwiRailWebUIAutomation.Tests
{
    class Tests
    {
        public void Tc1()
        {
            Assert.AreEqual("test", "tes1", "fail test1");
        }

        public void Tc2()
        {
            Assert.AreEqual("test", "tes1", "fail test2");
        }

        public void Tc3()
        {
            Assert.AreEqual("test", "test", "pass test");
        }
    }
}
