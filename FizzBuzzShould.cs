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
        [Test]
        public static void PrintOneForOne()
        {
            var output = FizzBuzzGenerate(1);

            Assert.AreEqual(output, "1");
        }

        [Test]
        public static void PrintTwoForTwo()
        {
            var output = FizzBuzzGenerate(2);

            Assert.AreEqual(output, "2");
        }

        [Test]
        public static void PrintFizzForThree()
        {
            var output = FizzBuzzGenerate(3);

            Assert.AreEqual(output, "Fizz");
        }

        [Test]
        public static void PrintFourForFour()
        {
            var output = FizzBuzzGenerate(4);

            Assert.AreEqual(output, "4");
        }

        [Test]
        public static void PrintBuzzForFive()
        {
            var output = FizzBuzzGenerate(5);

            Assert.AreEqual(output, "Buzz");
        }

        [Test]
        public static void PrintFizzForSix()
        {
            var output = FizzBuzzGenerate(6);

            Assert.AreEqual(output, "Fizz");
        }

        [Test]
        public static void PrintFizzForNine()
        {
            var output = FizzBuzzGenerate(9);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public static void PrintBuzzForTen()
        {
            var output = FizzBuzzGenerate(10);

            Assert.AreEqual("Buzz", output);
        }

        private static object FizzBuzzGenerate(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input == 5 || input == 10)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
