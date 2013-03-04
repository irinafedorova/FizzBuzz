using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzShould
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
        public static void PrintOneForOne()
        {
            var input = 1;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, One);
        }

        [Test]
        public static void PrintTwoForTwo()
        {
            var input = 2;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Two);
        }

        [Test]
        public static void PrintFizzForThree()
        {
            var input = 3;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void PrintFourForFour()
        {
            var input = 4;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Four);
        }

        [Test]
        public static void PrintBuzzForFive()
        {
            var input = 5;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Buzz);
        }

        [Test]
        public static void PrintFizzForSix()
        {
            var input = 6;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void PrintWoofForSeven()
        {
            var input = 7;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(output, Woof);
        }

        [Test]
        public static void PrintFizzForNine()
        {
            var input = 9;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Fizz, output);
        }

        [Test]
        public static void PrintBuzzForTen()
        {
            var input = 10;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Buzz, output);
        }

        [Test]
        public static void PrintWoofForForteen()
        {
            var input = 14;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(Woof, output);
        }

        [Test]
        public static void PrintFizzWoofForTwentyOne()
        {
            var input = 21;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzWoof, output);
        }

        [Test]
        public static void PrintFizzBuzzForFifteen()
        {
            var input = 15;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzz, output);
        }

        [Test]
        public static void PrintFizzBuzzForThirty()
        {
            var input = 30;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzz, output);
        }

        [Test]
        public static void PrintFizzWoofForFourtyTwo()
        {
            var input = 42;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzWoof, output);
        }

        [Test]
        public static void PrintBuzzWoofForThirtyFive()
        {
            var input = 35;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(BuzzWoof, output);
        }

        [Test]
        public static void PrintFizzBuzzWoofForHundredAndFive()
        {
            var input = 105;
            var output = FizzBuzzGenerate(input);

            Assert.AreEqual(FizzBuzzWoof, output);
        }

        [Test]
        public static void PrintUpToFifteen()
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
        public static void HasFuzzInOutpuut()
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
        public static void HasBuzzInOutpuut()
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
        public static void HasWoofInOutpuut()
        {
            var sb = new StringBuilder();

            var maxValue = 10000;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = FizzBuzzGenerate(i * WoofDevider);
                Assert.IsTrue(output.Contains(Woof));
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
