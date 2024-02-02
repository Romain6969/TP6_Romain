using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWallsHeight : MonoBehaviour
{
    public static float Randomposition()
    {
        float rdrange = Random.Range(-2f, 2f);
        return rdrange;
    }
}

    
