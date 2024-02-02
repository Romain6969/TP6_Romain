using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawningWalls : MonoBehaviour
{
    [SerializeField]
    private GameObject Walls;

    RandomWallsHeight randy;

    private float timerspawn = 0;

    void Update()
    {
        timerspawn += 1 * Time.deltaTime;

        if (timerspawn >= 2)
        {
            Debug.Log("I'm here!");
            GameObject instatieted =  Instantiate(Walls);
            instatieted.AddComponent<SlideWalls>();
            instatieted.transform.position = new Vector2(9, RandomWallsHeight.Randomposition());
            timerspawn = 0;
        }
    }
}
