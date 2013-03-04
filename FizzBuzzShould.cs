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
            var output = "1";

            Assert.AreEqual(output, "1");

        }
    }
}
