using UnityEngine;
using UnityEngine.SceneManagement;

public class BallFunctions : MonoBehaviour
{
    public float speed = 6.5f;
    public bool ballFell;
    public GameObject prefab;

    public int upgradePresent = 0;

    private SpriteRenderer _Sr;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 1) * speed;

        Time.timeScale = 1;

        ballFell = false;

        _Sr = GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (_Sr.color == Color.white)
        {
            _Sr.color = Color.blue;
        }

        else if (_Sr.color == Color.blue)
        {
            _Sr.color = Color.green;
        }

        else if (_Sr.color == Color.green)
        {
            _Sr.color = Color.magenta;
        }

        else if (_Sr.color == Color.magenta)
        {
            _Sr.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -8)
        {
            ballFell = true;
        }

        else
        {
            ballFell = false;
        }
        
        if (ballFell)
        {
            SceneManager.LoadScene("GameOver");
            Time.timeScale = 0;
        }

        if (upgradePresent > 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(prefab);
                upgradePresent --;
            }
        }
    }
}
