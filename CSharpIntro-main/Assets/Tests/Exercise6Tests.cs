using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 6: Lists")]
    [TestFixture]
    public static class Exercise6Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        private static readonly List<string> Names = new List<string>()
        {
            "Marten",
            "Faye",
            "Dora",
            "Hannelore"
        };

        [Test]
        public static void PrintNames()
        {
            foreach (string name in Names)
            {
                LogAssert.Expect(LogType.Log, name);
            }
            Exercise6.PrintNames(Names.ToList());
        }

        private static readonly List<string> Names2 = new List<string>()
        {
            "Marten",
            "Marty",
            "Faye",
            "Dora",
            "Hannelore",
            "Hanners"
        };

        [TestCase(null)]
        [TestCase("")]
        [TestCase("Mar")]
        [TestCase("Han")]
        [TestCase("Do")]
        [TestCase("Mari")]
        public static void FilterNamesByPrefix(string prefix)
        {
            var expected = String.IsNullOrEmpty(prefix) ? Names2 : Names2.Where(name => name.StartsWith(prefix)).ToList();
            var actual = Exercise6.FilterNamesByPrefix(Names2.ToList(), prefix);
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [TestCase()]
        [TestCase(1)]
        [TestCase(1, 2)]
        [TestCase(1, 2, 3, 4, 5, 6)]
        public static void Reverse(params int[] numbers)
        {
            var expected = numbers.Reverse().ToList();
            var actual = Exercise6.Reverse(numbers.ToList());
            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}
