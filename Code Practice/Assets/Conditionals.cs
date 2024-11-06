using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Brent Roberts");

        //Conditionals statements are one way programs "think"
        bool condition = true; //Notice 1) You need parenthesis around the condition 2) You need curly brackets around the code you want to run if the condition is true
        //3) The statement inside the curly brackets is indented.
        if (condition) //What happens if we change condition to false?
        {
            print("Do This Code");
        }

        //Choose a value for score that will make the print statement run.
        int score = 90;
        if (score > 50)
        {
            print("You won");
        }

        //Write an if statement that will determine if a number is even.
        int num = 8;
        if (num % 2 == 0)
        {
            print("The number is even");
        }

        //Else Statements - if the first condition doesn't work out, we still might want it to do something.

        //Write an if - else statement that prints when a number is even.
        int num2 = 7;
        if (num2 % 2 == 0)
        {
            print("The number is even.");
        }
        else
        {
            print("The number is odd.");
        }
        //Make an if - else statement that tells you whether or not the water is boiling based on temperature. Water boils at 100 degress celcius
        int temp = 42;
        if (temp >= 100)
        {
            print("The water is boiling");
        }
        else
        {
            print("The water is not boiling");
        }

        //Many times there are many situations we want to check - USE else if statements!

        //Write an else - if statement that prints 1) "It's hot outside. Wear Shorts" if it's above 80.
        // 2) "It's warm outside. No jacket needed." if the temp is above 70 degress 3) "It's getting chilly. Wear a jacket" if the temp is above 60 degress
        //Otherwise it should print "It's cold outside. Wear a heavy jacket"    
        int temp2 = 65;
        if(temp2 > 80)
        {
            print("It's hot outside. Wear Shorts"); //Change temp2 so you can get each statement to print
        }
        else if (temp2 > 70)
        {
            print("It's warm outside. No jacket needed"); //Will it ever print all the statements?
        }
        else if (temp2 > 60)
        {
            print("It's getting chilly. Wear a jacket");
        }
        else
        {
            print("It's cold outside. Wear a heavy jacket");
        }

        //It works for boolean operators to.

        int temp3 = 85;

        string weather = "Sunny";
        
        if (temp3 > 80 && weather == "Sunny")
        {
            print("Put on sunblock.");
        }

        whatToWear(85);
        whatToWear(75);
        whatToWear(65);
        whatToWear(30);
        winner(50, 70);
        winner 90, 40);

        //Write your own function that will tell you what to wear based on the temperature and call it for every possible situation in start

        void whatToWear(int temp2)
        {
            if (temp2 > 80)
            {
                print("It's hot outside. Wear Shorts"); 
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

        //Write a function that
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
