using UnityEngine;

public class Blocks : MonoBehaviour
{
    public Score scoreValue;
    public int pointWorth = 1;

    public Score destroyed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        scoreValue.currentScore += pointWorth;
        destroyed.objectsDestroyed++;
    }
}
