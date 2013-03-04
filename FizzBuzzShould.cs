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
        public static void PrintTwoFotTwo()
        {
            var output = FizzBuzzGenerate(2);

            Assert.AreEqual(output, "2");
        }

        private static object FizzBuzzGenerate(int input)
        {
            if (input == 1)
            {
                return "1";
            }
            else if (input == 2)
            {
                return "2";
            }

            return "";
        }
    }
}
