using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TriggerTouchWalls : MonoBehaviour
{
    [SerializeField]
    public GameObject PanelScore;
    public GameObject PanelGame;
    void OnCollisionEnter2D(Collision2D collision)
    {
        PanelScore.SetActive(true);
        PanelGame.SetActive(false);
        Destroy(gameObject);
        Scores.Score = 0;
    }
}
