using System;
using UnityEngine;

/// <summary>
/// Exercises for flow control (if, else and switch statements)
/// </summary>
public static class Exercise3
{
    /*
     * Create your own Clamp. It limits a value to be between a minimum and a maximum value.
     *
     * 'number' is the original value that needs to be possibly clamped.
     * 'min' is the minimum value that 'number' is allowed to be.
     * 'max' is the maximum value that 'number' is allowed to be,
     *
     * Take a look at the Unity documentation for Mathf.Clamp() if you are unsure:
     * https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
     *
     * DO NOT actually use Math.Clamp() or Mathf.Clamp() but implement your own version.
     */
    static Exercise3()
    {
    }

    public static void MyClamp(float number, float min, float max)
    {
        float newNumber = number;
        if (number <= min)
        {
            newNumber = min;
        }
        else if (number >= max)
        {
            newNumber = max;
        }
        Debug.Log(newNumber);
        // TODO Debug.Log() the clamped value.

    }

    /*
     * Convert real years into dog years (more accurately).
     *
     * The first real year equals 15 dog years.
     * The second real year equals 9 dog years.
     * Every additional real year equals 5 dog years.
     *
     * 'realYears' is guaranteed to be 0 or positive.
     */
    public static void InDogYearsAdvanced(int realYears)
    {
        int a = 0;
        if (realYears >= 1)
        {
            a+= 15;
        }
        if (realYears >=2)
        {
            a+= 9;
        }

        if (realYears > 2)
        {
            int b = (realYears - 2) * 5;
            a += b;
        }
        Debug.Log(a);
        // TODO Debug.Log() the dog years.

    }

    /*
     * Try to complete a quest where you need to deliver a certain amount of items.
     * The quest can only be completed if you have the full required amount.
     *
     * If you don't have enough items, you can't complete the quest and
     * the new item amount will be the same as the original 'itemAmount'.
     *
     * 'itemAmount' is the amount of items you currently have.
     * 'requiredAmount' is the amount of items that are required to complete the quest.
     *
     * 'itemAmount' is guaranteed to be 0 or positive.
     * 'requiredAmount' is guaranteed to be 0 or positive.
     */
    public static void TryCompleteQuest(int itemAmount, int requiredAmount)
    {
        int newAmount = itemAmount;
        if (itemAmount >= requiredAmount)
        {
            newAmount -= requiredAmount;
        }
        Debug.Log(newAmount);
        // TODO Debug.Log() the new item amount.

    }

    /*
     * Get a physical description of a person based on their age.
     *
     * Valid values are: Child, Teenager, and Adult.
     * A person is a Child if they are between 0 and 12 years old.
     * A person is a Teenager if they are between 13 and 17 years old.
     * A person is an Adult if they are +18 years old.
     *
     * 'age' is the age of the person in question.
     *
     * 'age' is guaranteed to be 0 or positive.
     */
    public static void GetAgeName(int age)
    {
        string description = "Adult";
        if (age <= 12)
        {
            description = "Child";
        }
        else if (age <= 17)
        {
            description = "Teenager";
        }
        Debug.Log(description);
        // TODO Debug.Log() the physical description of the person.

    }

    /*
     * Get the name of the month based on the numeric value.
     *
     * Valid values are: January, February, March, April, May, June, July,
     * August, September, October, November, December, and Unknown.
     *
     * 'monthValue' is the numeric value of the month.
     * 1 -> January
     * 2 -> February
     * ...
     * 12 -> December
     * Any other number -> Unknown
     *
     * 'monthValue' can either be positive or negative.
     *
     * Hint: Try to use a switch case.
     */
    public static void GetMonthName(int monthValue)
    {
        switch (monthValue)
        {
            case 1:
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("February");
                break;
            case 3:
                Debug.Log("March");
                break;
            case 4:
                Debug.Log("April");
                break;
            case 5:
                Debug.Log("May");
                break;
            case 6:
                Debug.Log("June");
                break;
            case 7:
                Debug.Log("July");
                break;
            case 8:
                Debug.Log("August");
                break;
            case 9:
                Debug.Log("September");
                break;
            case 10:
                Debug.Log("October");
                break;
            case 11:
                Debug.Log("November");
                break;
            case 12:
                Debug.Log("December");
                break;
            default:
                Debug.Log("Unknown");
                break;
        }
        // TODO Debug.Log() the name of the month;
        
    }

    /*
     * Get the name of the season based on a given month.
     *
     * Valid values for the month are:
     * January, February, March, April, May, June, July,
     * August, September, October, November, and December.
     *
     * Valid values for the season are: Spring, Summer, Fall, and Winter.
     *
     * From March to May is Spring.
     * From June to August is Summer.
     * From September to November is Fall.
     * From December to February is Winter.
     *
     * 'month' is the name of the month.
     *
     * Hint: Try to use a switch case using "fallthrough"-cases.
     */
    public static void GetSeason(string month)
    {
        switch (month)
        {
            case "March":
            case "April":
            case "May":
                Debug.Log("Spring");
                break;
            case "June":
            case "July":
            case "August":
                Debug.Log("Summer");
                break;
            case "September": 
            case "October":
            case "November":
                Debug.Log("Fall");
                break;
            case "December":
            case "January":
            case "February":
                Debug.Log("Winter");
                break;
        }
        // TODO Debug.Log() the name of the season;
        
    }
}
