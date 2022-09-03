using System.Globalization;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Editor.Tests
{
    [Category("Exercise 3: Flow Control")]
    [TestFixture]
    public static class Exercise3Tests
    {
        [TearDown]
        public static void Cleanup()
        {
            Utility.ClearLogConsole();
        }

        [TestCase(5, -10, 10)]
        [TestCase(0, 3, 8)]
        [TestCase(-7, -3, -1)]
        [TestCase(130, -99, 99)]
        public static void MyClamp(float value, float min, float max)
        {
            float expected = Mathf.Clamp(value, min, max);
            LogAssert.Expect(LogType.Log, expected.ToString(CultureInfo.InvariantCulture));
            Exercise3.MyClamp(value, min, max);
        }

        [TestCase(0, 0)]
        [TestCase(1, 15)]
        [TestCase(2, 24)]
        [TestCase(3, 29)]
        [TestCase(7, 15 + 9 + 5*5)]
        [TestCase(13, 15 + 9 + 11*5)]
        public static void InDogYearsAdvanced(int realYears, int expected)
        {
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise3.InDogYearsAdvanced(realYears);
        }


        [Test]
        public static void TryCompleteQuest([Values(0, 3, 7, 999)] int itemAmount,
                                         [Values(0, 1, 3, 5, 7, 19, 100, 1000)] int requiredAmount)
        {
            int expected = itemAmount >= requiredAmount ? itemAmount - requiredAmount : itemAmount;
            LogAssert.Expect(LogType.Log, expected.ToString());
            Exercise3.TryCompleteQuest(itemAmount, requiredAmount);
        }

        [TestCase(0, "Child")]
        [TestCase(5, "Child")]
        [TestCase(12, "Child")]
        [TestCase(13, "Teenager")]
        [TestCase(16, "Teenager")]
        [TestCase(17, "Teenager")]
        [TestCase(18, "Adult")]
        [TestCase(20, "Adult")]
        [TestCase(50, "Adult")]
        public static void GetAgeName(int age, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise3.GetAgeName(age);
        }


        [TestCase(1, "January")]
        [TestCase(2, "February")]
        [TestCase(3, "March")]
        [TestCase(4, "April")]
        [TestCase(5, "May")]
        [TestCase(6, "June")]
        [TestCase(7, "July")]
        [TestCase(8, "August")]
        [TestCase(9, "September")]
        [TestCase(10, "October")]
        [TestCase(11, "November")]
        [TestCase(12, "December")]

        [TestCase(-3, "Unknown")]
        [TestCase(0, "Unknown")]
        [TestCase(13, "Unknown")]
        [TestCase(1000, "Unknown")]
        public static void GetMonthName(int value, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise3.GetMonthName(value);
        }

        [TestCase("January", "Winter")]
        [TestCase("February", "Winter")]
        [TestCase("March", "Spring")]
        [TestCase("April", "Spring")]
        [TestCase("May", "Spring")]
        [TestCase("June", "Summer")]
        [TestCase("July", "Summer")]
        [TestCase("August", "Summer")]
        [TestCase("September", "Fall")]
        [TestCase("October", "Fall")]
        [TestCase("November", "Fall")]
        [TestCase("December", "Winter")]
        public static void GetSeason(string month, string expected)
        {
            LogAssert.Expect(LogType.Log, expected);
            Exercise3.GetSeason(month);
        }
    }
}
