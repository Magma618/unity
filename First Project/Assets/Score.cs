using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public float timer = 10f;
  
    // AddScore increments of score by 1.
    public void AddScore()
    {
        if (timer > 0f)
        {
            score++;
            print("Score: "+ score);
        }
        else
        {
            print("Out of time!")
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }
}
