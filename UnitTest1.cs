using NUnit.Framework;
using System;

namespace JenkinsProject
{
    public class Tests
    {

        [Test]
        public void TC7()
        {
            TestContext.WriteLine("Testing project");
            Console.WriteLine("Testing project");
            Assert.Pass();
        }
        [Test]
        public void TC1()
        {
            Assert.Pass();
        }
        [Test]
        public void TC2()
        {
            Assert.Pass();
        }
        [Test]
        public void TC3()
        {
            Assert.Pass();
        }

        [Test]
        public void TC4()
        {
            Assert.Pass();
        }
        [Test]
        public void TC5()
        {
            Assert.Pass();
        }
        [Test]
        public void TC6()
        {
            Assert.Pass();
        }
    }
}