using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        for (int i = 10; i > 0; i--)
        {
            print("i: " + i);
            for (int j = 0; j < 10; j++)
            {
                a += j;
            }
        
        }
        print(a);

        CountToTen();
        Countdown(8);
        ContructAGrid(10, 10);
    }

    void CountToTen()
    {
        //Use a for loop to count from 1 to 10, including 1 and 10. Print each index value.

        for (int num1 = 1; num1 <= 10; num1++)
        {
            print(num1);
        }
    }

    void Countdown (int start)
    {
        //Use a for loop[ to count from start down to 0. Print each index value.

        for (int num2 = start; num2 >= 0; num2--)
        {
            print(num2);
        }
    }
    
    void ContructAGrid(int sizeX, int sizeY)
    {
        //Create a nested for loop, with an outer loop incremeting
        //From -x to x and an inner loop incrementing from -y to y.
        //In each iteration of the inner for loop, print the following
        // "x: [value of x], y: [Value of y]"

        for (int x = -sizeX; x <= sizeX; x++)
        {
            for (int y = -sizeY; y <= sizeY; y++)
            {
                print("x: " + x + ", y: " + y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
