using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzbuzz
        public FizzBuzzTests() => _fizzbuzz - new FizzBuzzService();

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("2", _fizzbuzz.Print(2));
        }

        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", _fizzbuzz.Print(3));
        }

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", _fizzbuzz.Print(5));
            Assert.AreEqual("Buzz", _fizzbuzz.Print(10));
        }

        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzbuzz.Print(15));
            Assert.AreEqual("FizzBuzz", _fizzbuzz.Print(30));
        }
    }
}
