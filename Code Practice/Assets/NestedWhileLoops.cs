using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedWhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Brent Roberts");
        int score = 0;
        while (score < 5)
        {
            print("You can still win!");
            score++;
        }
        print("You won!");

        //Nested while loops have a while loop inside a while loop
        //The loop on the inside will fully run for each iteration of the outside loop.

        int i = 0;
        while (i < 3)
        {
            int j = 0;
            print("B");
            i++;
            while (j < 2)
            {
                print("A");
                j++;
            }
        }
        CountToTen();
        CountToTwentyEven();
        CountToTwentyOdd();
        ALoopInALoop();
    }

    void CountToTen()
    {
        //Construct a while loop to count from 1 to 10 (including 1 and 10) Print each index to the console.
        int num1 = 0;
        while (num1 < 10)
        {
            num1++;
            print(num1);
        }
    }

    void CountToTwentyEven()
    {
        //Construct a while loop to count from 0 to 20 only printing even numbers

        int num2 = 0;
        while (num2 < 20)
        {
            num2 += 2;
            print(num2);
        }
    }

    void CountToTwentyOdd()
    {
        int num3 = -1;
        while (num3 < 20)
        {
            num3 += 2;
            print(num3);
        }
    }

    void ALoopInALoop()
    {
        //Using a nested while loop count from 1 to 100. Inner and outer loops should run 10 times each
        int num4 = 0;
        while (num4 < 100)
        {
            int num5 = 0;
            while (num5 < 10)
            {
                num4++;
                num5++;
                print(num4);
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
