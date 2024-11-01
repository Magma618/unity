using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Brent Roberts");

        int score = 70;
        if (score > 100)
        {
            print("You won!");
        }
        else if (score > 70)
        {
            print("You're getting close!");
        }
        else if (score > 40)
        {
            print("Real progress!");
        }
        else if (score >= 0)
        {
            print("Keep trying!");
        }
        else
        {
            print("You lost! Try again.");
        }

        whatToWear(85);
        whatToWear(75);
        whatToWear(65);
        whatToWear(30);
        winningteam(50, 20);
        winningteam(10, 70);
        winningteam(25, 25);

        GreaterThanOrEqualTo(25, 200);
        IsEven(4);
        GetLetterGrade(91);
        GetLetterGrade(75);
        
    }

    void whatToWear(int temp2)
    {
        if (temp2 > 80)
        {
            print("It's hot outside. Wear shorts");
        }
        else if (temp2 > 70)
        {
            print("It's warm outside. No jacket needed");
        }
        else if (temp2 > 60)
        {
            print("It's getting chilly. Wear a jacket");
        }
        else
        {
            print("It's cold outside. Wear a heavy jacket");
        }
    }

    //Write a function that determines if Team A won, Team B won, or it was a tie. Them call it in the start method
    //using different values such that Team A wins, Team B wins, and they tie.

    void winningteam(int scoreA, int scoreB)
    {
        if (scoreA == scoreB)
        {
            print("Teams tied!");
        }
        else if (scoreA > scoreB)
        {
            print("TeamA Won");
        }
        else
        {
            print("TeamB Won");
        }
    }

    void GreaterThanOrEqualTo(int numOne, int numTwo)
    {
        // Use a conditional structure to print whether numOne is greater than or equal to numTwo.
        if (numOne >= numTwo)
        {
            print("true");
        }
        else
        {
            print("false");
        }
    }

    void IsEven(int num)
    {
        // Use conditionals to print whether num is even or odd (Hint: use % modulo operator)
        if (num % 2 == 0)
        {
            print("true");
        }
        else
        {
            print("false");
        }
    }

    void GetLetterGrade(float percentage)
    {
        // Use conditionals to print the equivalent letter grade of the given percentage.
      if (percentage >= 90)
        {
            print("A");
        }
      else if (percentage >= 80)
        {
            print("B");
        }
      else if (percentage >= 70)
        {
            print("C");
        }
      else if (percentage >= 60)
        {
            print("D");
        }
        else
        {
            print("F");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
