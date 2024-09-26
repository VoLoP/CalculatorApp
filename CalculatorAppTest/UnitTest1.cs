using CalculatorApp;

namespace CalculatorAppTest
{
    public class Tests
    {
        //public int MyProperty { get; private set; }

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
        public void EnterTwoValidNumbersReturnsAValidNumber1()
        {
            int v1 = 2;
            int v2 = 3;

            var res = myCalc.Add(v1, v2);

            Assert.That(res, Is.EqualTo(5), "2+3 must return 5");
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
            Assert.Throws<Exception>(() => myCalc.Divide(6, 0), "Division by zero must throw Exception");
        }

        //public void DivideByZeroThrowsException()
        //{
        //
        //    TestDelegate action = () => myCalc.Divide(6, 0);

        //
        //    Assert.Throws<DivideByZeroException>(action, "Division by zero must throw DivideByZeroException");
        //}

        [TestCase(1, 2, 3)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 0, 0)]
        public void AddTestCases(int v1, int v2, int expected)
        {
            // Act
            var result = myCalc.Add(v1, v2);

            // Assert
            Assert.That(result, Is.EqualTo(expected), $"{v1} + {v2} must return {expected}");
        }
    }
}