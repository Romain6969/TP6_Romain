using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Point1");
        Scores.Score = 1 + Scores.Score;
    }
}
