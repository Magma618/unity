using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Brent Roberts");

        string[] groceries = { "Lemons", "Aluminum Foil", "Ice Cream" };
        string[] groceriesTwo = groceries;

        groceries[1] = "Ice Cream";
        groceriesTwo[1] = "Ice Cream";

        groceries = new string[] { "Lemons", "Aluminum Foil", "Ice Cream" };

        print(groceriesTwo[1]);

        int num = 0;
        int numTwo = num;

        num++;

        print(numTwo);

        int[] array = { 9, 24, 13, 18, 11 };
        LinearSearch(array, 13);
    }
    //Declare an array of integers called numbers with compile time values: 10, 20 , 30 , 40 ,50

    //Declare array of stings with size 5 and no elements.

    void LinearSearch(int[] array, int value)
    {
        //Search through numbers until finding the value. Once value is found print the index where it was found.
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                print (i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
