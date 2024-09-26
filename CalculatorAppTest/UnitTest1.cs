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
            Assert.That(res, Is.EqualTo(5), "3+2 must return 5");
        }
        [Test]
        public void SubtractTwoValidNumbersReturnsAValidNumber()
        {
            var res = myCalc.Subtract(5, 3);
            Assert.That(res, Is.EqualTo(2), "5-3 must return 2");
        }

        [Test]
        public void MultiplyTwoValidNumbersReturnsAValidNumber()
        {
            var res = myCalc.Multiply(2, 3);
            Assert.That(res, Is.EqualTo(6), "2*3 must return 6");
        }

        [Test]
        public void DivideTwoValidNumbersReturnsAValidNumber()
        {
            var res = myCalc.Divide(6, 3);
            Assert.That(res, Is.EqualTo(2), "6/3 must return 2");
        }

        [Test]
        public void DivideByZeroThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => myCalc.Divide(6, 0), "Division by zero must throw DivideByZeroException");
        }
    }
}