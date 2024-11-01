using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparisons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int a = 3;
        int b = 4;
        print(a < b);

        int c = 10;
        int d = 3;
        print(c >= 8 && d != 4);

        int x = 8;
        int y = 50;
        print(x == y || y <= 24);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
