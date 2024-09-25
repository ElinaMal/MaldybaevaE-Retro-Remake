using UnityEngine;

public class PrefabFunction : MonoBehaviour
{
    public float speed = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
    }
}
