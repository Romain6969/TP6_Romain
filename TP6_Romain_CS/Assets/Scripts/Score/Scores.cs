using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    public static int Score = 0;
    public TMP_Text PointsScores;
    public TMP_Text NotesScores;

    void Update()
    {
        PointsScores.text = ($"{Score}");
        NotesScores.text = ($"Score : {Score}");
    }
}
