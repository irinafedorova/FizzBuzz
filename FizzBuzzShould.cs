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
        public static void PrintFourForFour()
        {
            var output = FizzBuzzGenerate(4);

            Assert.AreEqual(output, "4");
        }

        [Test]
        public static void PrintFizzForThree()
        {
            var output = FizzBuzzGenerate(3);

            Assert.AreEqual(output, "Fizz");
        }

        private static object FizzBuzzGenerate(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
            else 
            {
                return input.ToString();
            }
        }
    }
}
