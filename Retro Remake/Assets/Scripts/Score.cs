using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int currentScore;
    public TMPro.TMP_Text scoreText;

    public int objectsDestroyed;

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + currentScore.ToString());
    }
}
