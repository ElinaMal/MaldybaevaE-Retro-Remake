using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BallFunctions : MonoBehaviour
{
    public float speed = 6.5f;
    public bool ballFell;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 1) * speed;

        Time.timeScale = 1;

        ballFell = false;
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
            SceneManager.LoadScene(sceneName: "GameOver");
            Time.timeScale = 0;
        }
    }
}
