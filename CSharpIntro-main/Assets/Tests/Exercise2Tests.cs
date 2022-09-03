using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 2: Bools")]
    [TestFixture]
    public static class Exercise2Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        [Test]
        public static void IsEven([Values(-5, 0, 1, 2, 4, 7, 13, 18)] int value)
        {
            bool expected = value % 2 == 0;
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise2.IsEven(value);
        }

        [Test]
        public static void CanBuyGame([Values(-10f, 0f, 30f)] float money,
                               [Values(-15f, -10f, -5f, 0f, 15f, 30f, 60f)] float price)
        {
            bool expected = money >= price;
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise2.CanBuyGame(money, price);
        }

        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        public static void IsSchoolDay(int index, bool expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise2.IsSchoolDay(index);
        }

        [TestCase(0, false)]
        [TestCase(3, false)]
        [TestCase(12, false)]
        [TestCase(13, true)]
        [TestCase(15, true)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, false)]
        [TestCase(20, false)]
        [TestCase(99, false)]
        public static void IsTeenager(int age, bool expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise2.IsTeenager(age);
        }

        [TestCase(-11.3f, true)]
        [TestCase(-2f, false)]
        [TestCase(0f, false)]
        [TestCase(0.1f, false)]
        [TestCase(7.5f, false)]
        [TestCase(79.11f, true)]
        public static void IsMovingFast(float xSpeed, bool expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise2.IsMovingFast(xSpeed);
        }
    }
}
