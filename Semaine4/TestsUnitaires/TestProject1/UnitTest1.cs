using NUnit.Framework.Legacy;
using System.Runtime.CompilerServices;
using TestsUnitaires;

namespace TestProjet1
{
    public class Tests
    {   //https://www.youtube.com/watch?v=24ytq8JP2jI&ab_channel=CuriousDrive%3ASolveCodingProblems%26WinPrizes%21
        private Calculs calculs;

        [SetUp]
        public void Setup()
        {
           calculs = new Calculs();
        }

        [Test]
        public void TestAireCercle()
        {
            Assert.That(calculs.AireCercle(10), Is.EqualTo(314.1592653589793));
            //ClassicAssert.AreEqual(314.1592653589793, calculs.AireCercle(10));
            //Assert.Pass();
        }

        [Test]
        public void TestAireRectangle()
        {
            Assert.That(calculs.AireRectangle(10, 10), Is.EqualTo(100));
        }
    }
}