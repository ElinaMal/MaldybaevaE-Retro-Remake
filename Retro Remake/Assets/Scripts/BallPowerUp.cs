using UnityEngine;

public class BallPowerUp : MonoBehaviour
{
    public BallFunctions reference;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        reference.upgradePresent ++;
        Destroy(gameObject);
    }
}
