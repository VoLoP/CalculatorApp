namespace CalculatorAppTest
{
    public class Tests
    {
        [SetUp]

        CalculatorClass myCalc;
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