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
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";
        private const string One = "1";
        private const string Two = "2";
        private const string Four = "4";
        private const string Comma = ", ";

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
            var output = FizzBuzzGenerate(3);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void PrintFourForFour()
        {
            var output = FizzBuzzGenerate(4);

            Assert.AreEqual(output, Four);
        }

        [Test]
        public static void PrintBuzzForFive()
        {
            var output = FizzBuzzGenerate(5);

            Assert.AreEqual(output, Buzz);
        }

        [Test]
        public static void PrintFizzForSix()
        {
            var output = FizzBuzzGenerate(6);

            Assert.AreEqual(output, Fizz);
        }

        [Test]
        public static void PrintFizzForNine()
        {
            var output = FizzBuzzGenerate(9);

            Assert.AreEqual(Fizz, output);
        }

        [Test]
        public static void PrintBuzzForTen()
        {
            var output = FizzBuzzGenerate(10);

            Assert.AreEqual(Buzz, output);
        }

        [Test]
        public static void PrintFizzBuzzForFifteen()
        {
            var output = FizzBuzzGenerate(15);

            Assert.AreEqual(FizzBuzz, output);
        }

        [Test]
        public static void PrintFizzBuzzForThirty()
        {
            var output = FizzBuzzGenerate(30);

            Assert.AreEqual(FizzBuzz, output);
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

            Assert.AreEqual("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
        }

        private static object FizzBuzzGenerate(int input)
        {
            var isDivisibleByThree = input % 3 == 0;
            var isDivisibleByFive = input % 5 == 0;

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
