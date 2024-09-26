using CalculatorApp;

namespace CalculatorAppTest
{
    public class Tests
    {
        public int MyProperty { get; private set; }

        CalculatorClass myCalc;

        [SetUp]
        public void Setup()
        {
            myCalc = new CalculatorClass();
        }

        [Test]
        public void EnterTwoValidNumbersReturnsAValidNumber()
        {
            var res = myCalc.Add(2, 3);
            Assert.That(res, Is.EqualTo(5), "3+2 must returns 5");
        }
    }
}