using NUnit.Framework;

namespace KiwiRailWebUIAutomation.Tests
{
    public class Tests
    {
        [Test]
        public void Tc1()
        {
            Assert.AreEqual("test", "tes1", "fail test1");
        }
        [Test]
        public void Tc2()
        {
            Assert.AreEqual("test", "tes1", "fail test2");
        }
        [Test]
        public void Tc3()
        {
            Assert.AreEqual("test", "test", "pass test");
        }
    }
}
