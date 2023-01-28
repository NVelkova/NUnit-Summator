using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {

        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var numbers = new double[] { 1, 3 };
            var actual = Summator.Sum(numbers);

            var expected = 4;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var numbers = new double[] { -1, -3 };
            var actual = Summator.Sum(numbers);

            var expected = -4;
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumWithZero()
        {
            var numbers = new double[] { 1, 0 };
            var actual = Summator.Sum(numbers);

            var expected = 1;
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumPositiveWithNegative()
        {
            var numbers = new double[] { 3, -2 };

            var actual = Summator.Sum(numbers);

            var expected = 1;
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumWithDouble()
        {
            var numbers = new double[] { (double)3.5, (double)0.5 };

            var actual = Summator.Sum(numbers);

            var expected = 4.0;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Summator_SumLongNumbers()
        {
            var numbers = new double[] { 2000000, 3000000, 2000000 };
            var actual = Summator.Sum(numbers);
            var expected = 7000000;
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var numbers = new double[] { 3 };
            var actual = Summator.Sum(numbers);
            var expected = 3;
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumTwoPositive()
        {
            var numbers = new double[] { 3, 5 };
            var actual = Summator.Sum(numbers);
            var expected = 9;
            Assert.AreNotEqual(actual, expected);

        }

        [Test]
        public void Test_Summator_SumTwoNegative()
        {
            var numbers = new double[] { -3, -5 };
            var actual = Summator.Sum(numbers);
            var expected = -8;
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_Summator_SumNegativeAndCheckRange()
        {
            var numbers = new double[] { -3, -5 };
            var actual = Summator.Sum(numbers);
            var expected = -8;
            Assert.That(expected, Is.InRange(-9, 0));

        }

        //Average
        [Test]
        public void Test_Summator_AverageNum()
        {
            var numbers1 = new double[] { 2, 8 };
            var actual = Summator.Average(numbers1);
            var expected = 5;
            Assert.AreEqual(expected, actual);

        }

        //Multiplication
        [Test]
        public void Test_Summator_MultiplicationNum()
        {
            var numbers = new double[] { 3, 7 };
            var actual = Summator.Multiplication(numbers);
            var expected = 21;
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_Summator_MultiplicationWithNegativeNum()
        {
            var numbers = new double[] { 3, -7 };
            var actual = Summator.Multiplication(numbers);
            var expected = -21;
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_Summator_MultiplicationWithZero()
        {
            var numbers = new double[] { 3, 0 };
            var actual = Summator.Multiplication(numbers);
            var expected = 3;
            Assert.That(actual, Is.Not.EqualTo(expected));

        }
        //Division

        [Category("Medium")]
        [Test]
        public void Test_Summator_DivisionWithTwoPositive()
        {
            var numbers = new double[] { 2 };
            var actual = Summator.Division(numbers);
            var expected = 5;
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Data-Driven Testing
        [TestCase(new double[] { 1, 3 }, 4)]
        [TestCase(new double[] { -1, -3 }, -4)]
        [TestCase(new double[] { 3 }, 3)]
        [TestCase(new double[] { 1, -2 }, -1)]
        [TestCase(new double[] { 3, 0 }, 3)]
        [TestCase(new double[] { 3.5, 0.5 }, 4)]
        [TestCase(new double[] { }, 0)]
        public void Test_Summator_SumDDT(double[] values, long expected)
        {
            var actual = Summator.Sum(values);
            Assert.That(actual, Is.EqualTo((double)expected));
        }
        [TestCase(new double[] {1, 2}, 1.5)]
        [TestCase(new double[] {2, 8}, 5)]
        [TestCase(new double[] {-1, -3}, -2)]
        public void Test_Summator_Average(double[] values, double expected)
        {
            var actual = Summator.Average(values);
            Assert.That(actual, Is.EqualTo((double)expected));
        }
        [TestCase(new double[] {3, 5}, 15)]
        [TestCase(new double[] { 3, -5 }, -15)]
        [TestCase(new double[] { }, 1)]
        [TestCase(new double[] {3, 0}, 0)]
        public void Test_Summator_Multiplication(double[] values, long expected)
        {
            var actual = Summator.Multiplication(values);
            Assert.That(actual, Is.EqualTo((double)expected));
        }
        [TestCase(new double[] { 2 }, 5)]
        [TestCase(new double[] { 10 }, 1)]
        public void Test_Summator_Division(double[] values, long expected)
        {
            var actual = Summator.Division(values);
            Assert.That(actual, Is.EqualTo((double)expected));
        }

    }
        
}