using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideWalls : MonoBehaviour
{
    RandomWallsHeight randy;
    private int WallSlidingSpeed = 7;

    private float timerdelete = 0;

    

    void FixedUpdate()
    {
        timerdelete += 1 * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-11, transform.position.y), WallSlidingSpeed * Time.deltaTime);

        if (timerdelete >= 4)
        {
            Destroy(gameObject); 
        }
    }
}
