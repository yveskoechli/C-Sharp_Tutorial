using System;
using UnityEngine;

/// <summary>
/// Exercises for loops (for, while)
/// </summary>
public static class Exercise5
{
    /*
     * Calculate the factorial (!) of a number.
     *
     * Factorial !n is the product of all numbers from 1 to n.
     * E.g. !4 = 1 * 2 * 3 * 4 = 24
     *
     * !0 is defined to be 1.
     *
     * 'number' is guaranteed to be 0 or positive.
     */
    public static void Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        Debug.Log(result);
        // TODO Debug.Log() the result.

    }

    /*
     * Shout out "AHH" with a customizable length.
     * Add H's to the shout based on the provided length.
     * E.g. 4 -> AHHHH
     *
     * 'length' is the amount of H's to shout.
     *
     * 'length' is guaranteed to be 0 or positive.
     *
     * Hint: Use string concatenation using + to slowly add characters to the final string.
     * Hint: Don't forget the initial A.
     */
    public static void Shout(int length)
    {
        string ahh = "A";
        for (int i = 0; i < length; i++)
        {
            ahh += "H";
        }
        Debug.Log(ahh);
        // TODO Debug.Log() the shout.

    }

    /*
     * Print a square of #'s using a single Debug.Log().
     * E.g.
     * 2x2   2x5     4x3
     * ##    #####   ###
     * ##    #####   ###
     *               ###
     *               ###
     *
     * 'height' is guaranteed to be 0 or positive.
     * 'width' is guaranteed to be 0 or positive.
     *
     * 
     * Hint: You will need to use nested loops (loop inside a loop).
     * Hint: Start with an empty string and use string concatenation using the + operator
     *       to slowly add characters to the final string.
     * Hint: Use \n to add a line breaks for each 'row' of the square.
     */
    public static void PrintSquare(int height, int width)
    {
        string print = "";
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                print += "#";
            }
            print += "\n";
        }
        Debug.Log(print);
        // TODO Debug.Log() the square.

    }

    /*
     * Check if a given number is a prime number.
     * Prime numbers are only divisible by 1 and itself.
     *
     * 0 and 1 are not considered primes.
     *
     * 'number is guaranteed to be 0 or positive.
     *
     * Hint: You only need to check if 'number' is divisible by numbers smaller than 'number'.
     * Hint: Do not divide by 0.
     * Hint: Numbers are always divisible by 1. So you need to check starting with 2.
     * Hint: Even numbers (every second number) are always divisible by 2. Check this first and the rest only if necessary.
     *       If you do this, you can start with 3 and skip every other number (3,5,7,9,...) in your loop
     *       But don't forget: 2 itself is a prime!
     *
     * Advanced Hint: You only need to check numbers smaller than square root (√) of 'number'. Have a look at Mathf.Sqrt()
     * https://docs.unity3d.com/ScriptReference/Mathf.Sqrt.html
     */
    public static void IsPrime(int number)
    {
        int primNumber = 1;
        bool isPrim = false;
        for (int i = 2; i <= number; i++)
        {
            primNumber = number % i;
            if (primNumber == 0)
            {
                if (i == number)
                {
                    isPrim = true;
                }
                else
                {
                    isPrim = false;
                    i = number;
                }
            }
            /*else
            {
                isPrim = false;
                i = number;
            }*/
        }
        Debug.Log(isPrim);
        // TODO Debug.Log() if prime or not.

    }
}
