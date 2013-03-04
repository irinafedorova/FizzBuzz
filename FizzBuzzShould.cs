using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGeneratorShould
    {
        private const int FizzDevider = 3;
        private const int BuzzDevider = 5;
        private const int WoofDevider = 7;

        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Woof = "Woof";

        private const string FizzBuzz = "FizzBuzz";
        private const string FizzWoof = "FizzWoof";
        private const string BuzzWoof = "BuzzWoof";
        private const string FizzBuzzWoof = "FizzBuzzWoof";

        private const string Comma = ", ";

        private const string One = "1";
        private const string Two = "2";
        private const string Four = "4";

        [Test]
        public static void OutputOneForOne()
        {
            var input = 1;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, One);
        }

        [Test]
        public static void OutputTwoForTwo()
        {
            var input = 2;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Two);
        }

        [Test]
        public static void OutputFizzForThree()
        {
            var input = 3;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void OutputFourForFour()
        {
            var input = 4;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Four);
        }

        [Test]
        public static void OutputBuzzForFive()
        {
            var input = 5;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Buzz);
        }

        [Test]
        public static void OutputFizzForSix()
        {
            var input = 6;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void OutputWoofForSeven()
        {
            var input = 7;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Woof);
        }

        [Test]
        public static void OutputFizzForNine()
        {
            var input = 9;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Fizz, output);
        }

        [Test]
        public static void OutputBuzzForTen()
        {
            var input = 10;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Buzz, output);
        }

        [Test]
        public static void OutputWoofForForteen()
        {
            var input = 14;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Woof, output);
        }

        [Test]
        public static void OutputFizzWoofForTwentyOne()
        {
            var input = 21;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzWoof, output);
        }

        [Test]
        public static void OutputFizzBuzzForFifteen()
        {
            var input = 15;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzz, output);
        }

        [Test]
        public static void OutputFizzBuzzForThirty()
        {
            var input = 30;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzz, output);
        }

        [Test]
        public static void OutputFizzWoofForFourtyTwo()
        {
            var input = 42;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzWoof, output);
        }

        [Test]
        public static void OutputBuzzWoofForThirtyFive()
        {
            var input = 35;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(BuzzWoof, output);
        }

        [Test]
        public static void OutputFizzBuzzWoofForHundredAndFive()
        {
            var input = 105;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzzWoof, output);
        }

        [Test]
        public static void OutputUpToFifteen()
        {
            var sb = new StringBuilder();

            var maxValue = 15;

            for (int i = 1; i <= maxValue; i++)
            {
                sb.Append(FizzBuzzGenerate(i));
                if (i < maxValue)
                {
                    sb.Append(Comma);
                }
            }

            var result = sb.ToString();

            Assert.AreEqual("1, 2, Fizz, 4, Buzz, Fizz, Woof, 8, Fizz, Buzz, 11, Fizz, 13, Woof, FizzBuzz", result);
        }

        [Test]
        public static void HasFizzInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * FizzDevider);
                Assert.IsTrue(output.Contains(Fizz));
            }
        }

        [Test]
        public static void HasBuzzInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * BuzzDevider);
                Assert.IsTrue(output.Contains(Buzz));
            }
        }

        [Test]
        public static void HasWoofInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * WoofDevider);
                Assert.IsTrue(output.Contains(Woof));
            }
        }

        [Test]
        public static void HasFizzBuzzInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * FizzDevider * BuzzDevider);
                Assert.IsTrue(output.Contains(Fizz) && output.Contains(Buzz));
            }
        }

        [Test]
        public static void HasFizzWoofInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * FizzDevider * WoofDevider);
                Assert.IsTrue(output.Contains(Fizz) && output.Contains(Woof));
            }
        }

        [Test]
        public static void HasBuzzWoofInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * BuzzDevider * WoofDevider);
                Assert.IsTrue(output.Contains(Buzz) && output.Contains(Woof));
            }
        }

        [Test]
        public static void HasFizzBuzzWoofInOutput()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * FizzDevider * BuzzDevider * WoofDevider);
                Assert.IsTrue(output.Contains(Fizz) && output.Contains(Buzz) && output.Contains(Woof));
            }
        }

        private static string FizzBuzzGenerate(int input)
        {
            var isDivisibleByThree = input % FizzDevider == 0;
            var isDivisibleByFive = input % BuzzDevider == 0;
            var isDivisibleBySeven = input % WoofDevider == 0;

            if (isDivisibleBySeven && isDivisibleByThree && isDivisibleByFive)
            {
                return FizzBuzzWoof;
            }

            if (isDivisibleBySeven && isDivisibleByFive)
            {
                return BuzzWoof;
            }

            if (isDivisibleBySeven && isDivisibleByThree)
            {
                return FizzWoof;
            }

            if (isDivisibleBySeven)
            {
                return Woof;
            }

            if (isDivisibleByThree && isDivisibleByFive)
            {
                return FizzBuzz;
            }

            if (isDivisibleByThree)
            {
                return Fizz;
            }

            if (isDivisibleByFive)
            {
                return Buzz;
            }

            return input.ToString();
        }
    }
}
