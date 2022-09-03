using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 4: Strings")]
    [TestFixture]
    public static class Exercise4Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        private const string DefaultGreeting = "Hello friend.";

        [TestCase("Cats", "Cool Cats")]
        [TestCase("Game", "Cool Game")]
        public static void MakeCool(string thing, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise4.MakeCool(thing);
        }

        [TestCase("Marten", "Hello Marten.")]
        [TestCase("Dora", "Hello Dora.")]
        [TestCase("Penelope", "Hello Penelope.")]
        [TestCase("", DefaultGreeting)]
        [TestCase(null, DefaultGreeting)]
        public static void Greet(string name, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise4.Greet(name);
        }
    }
}
