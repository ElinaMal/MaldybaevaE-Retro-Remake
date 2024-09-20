using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public Score scoreValue;
    public int pointWorth = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        scoreValue.currentScore += pointWorth;
    }
}
