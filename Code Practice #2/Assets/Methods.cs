using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public int[] array = { 1, 2, 3, 4, 5 };

    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        print(Add(a, b));

        Welcome();
        print(ArraySum(array));
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    void Welcome()
    {
        print("Welcome to the program!");
    }

    //Declare a method called ArraySum which takes in an array of integers as a parameter and iterates
    //Through the array to return the sum of its elements

    int ArraySum(int[] array)
    {
        int returnValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            returnValue += array[i];
        }
        return returnValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
