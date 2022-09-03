using System;
using Codice.Client.BaseCommands;
using UnityEngine;

/// <summary>
/// Simple math exercises.
/// </summary>
public static class Exercise1
{
    /*
     * Add two numbers together.
     *
     * 'a' is the first summand.
     * 'b' is the second summand.
     */
    public static void Add(int a, int b)
    {
        
        // TODO Debug.Log() the sum of both values.
        int sum = a + b;
        Debug.Log(sum);

    }

    /*
     * Convert real years into dog years.
     *
     * One real year equals seven dog years.
     *
     * 'realYears' is guaranteed to be 0 or positive.
     */
    public static void InDogYears(int realYears)
    {
        int dogYears = realYears * 7;
        Debug.Log(dogYears);
        // TODO Debug.Log() the dog years.

    }
    
    /*
     * Calculate the new price of an item after applying a discount percentage.
     * IGNORE any rounding of the price that would be necessary to represent valid amounts of euro and cents.
     *
     * 'price' is the price of the item.
     * 'discount' is the discount percentage.
     *
     * The 'discount' percentage is a float number between 0 and 1.
     * 0.0f -> 0%
     * 0.3f -> 30%
     * 0.55f -> 55%
     * 1.0f -> 100%
     * 
     * 'price' is guaranteed to be 0 or positive.
     * 'discount' is guaranteed to be between 0 and 1.
     */
    public static void ApplyDiscount(float price, float discount)
    {
        float newPrice = price - (price * discount);
        Debug.Log(newPrice);
        // TODO Debug.Log() the new price with the discount applied.

    }

    /*
     * Share a cake with your friends.
     * Calculate how much cake everyone gets if you share the cake equally with everyone.
     *
     * 'grams' is the weight of the cake.
     * 'friends' is the amount of friends you'll share the cake with.
     *
     * 'grams' is guaranteed to be 0 or positive.
     * 'friends' is guaranteed to be 0 or positive.
     * 
     * Hint: Don't forget to give yourself a piece of cake as well.
     */
    public static void ShareCake(float grams, int friends)
    {
        friends++;
        float amount = grams / friends;
        Debug.Log(amount);
        // TODO Debug.Log() the amount of cake everyone gets.
        
    }

    /*
     * Calculate the new price of an item after applying a coupon that give you a flat rebate value.
     * The final price can not be below 0, meaning you can not get money back by using the coupon.
     *
     * 'price' is the price of the item.
     * 'couponValue' is the monetary value of the coupon.
     * 
     * 'price' is guaranteed to be 0 or positive.
     * 'couponValue' is guaranteed to be 0 or positive.
     *
     * Hint: Check the Mathf functions to prevent a value from going below 0.
     */
    public static void ApplyCoupon(float price, float couponValue)
    {
        float newPrice = price - couponValue;
        newPrice = Mathf.Clamp(newPrice,0,100);
        newPrice = Mathf.Floor(0);
        Debug.Log(newPrice);
        // TODO Debug.Log() the new price with the coupon applied.

    }

    /*
     * Calculate a new health value of the player as it is being changed (by e.g. health potions or damage).
     *
     * The minimum allowed health of the player is 0.
     * The maximum allowed health of the player is 100.
     * You need to prevent the new health to be smaller than 0 and larger than 100.
     *
     * 'currentHealth' is the current health of the player.
     * 'changeInHealth' is the amount that the current health of the player should be changed by.
     *
     * 'currentHealth' is guaranteed to be 0 or positive.
     * 'changeInHealth' can either be positive or negative.
     *
     * Check the Mathf functions to prevent a value from outside of a certain range.
     */
    public static void ChangeHealth(int currentHealth, int changeInHealth)
    {
        int newHealth = currentHealth + changeInHealth;
        newHealth = Mathf.Clamp(newHealth, 0, 100);
        Debug.Log(newHealth);
        // TODO Debug.Log() the new health.

    }

    /*
     * You want to put all your books into shelves.
     * Each shelve can hold 8 books.
     * Calculate how many shelves you need to hold all books.
     *
     * 'books' is the amount of books.
     *
     * 'books' is guaranteed to be 0 or positive.
     *
     * Hint: Remember to use floats in your division: 5/4 -> 1 but 5/4.0f -> 1.25f
     * Hint: Mathf.CeilToIn() might be helpful:
     * https://docs.unity3d.com/ScriptReference/Mathf.CeilToInt.html
     */
    public static void RequiredShelves(int books)
    {
        float shelveAmount = books / 8f;
        shelveAmount = Mathf.CeilToInt(shelveAmount);
        Debug.Log(shelveAmount);
        // TODO Debug.Log() the amount of shelves needed.
        
    }

    /*
     * You hate empty spaces in your shelves.
     * You reconsider and decide to only buy those shelves that you can fully fill with books.
     *
     * Each shelve can hold 8 books.
     * Calculate how many books will be left over after you filled all the shelves you bought with books.
     *
     * 'books' is the total amount of books.
     *
     * 'books' is guaranteed to be 0 or positive.
     *
     * Hint: % (Remainder) might be helpful:
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
     */
    public static void LeftoverBooks(int books)
    {
        float leftOverBooks = books % 8;
        Debug.Log(leftOverBooks);
        // TODO Debug.Log() the amount of leftover books.
        
    }
}
