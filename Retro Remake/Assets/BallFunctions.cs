using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BallFunctions : MonoBehaviour
{
    public float speed = 8;
    public bool ballFell;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ballFell = false;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1,1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = transform.position;

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
            Time.timeScale = 0;
            SceneManager.LoadScene(sceneName: "GameOver");
        }
    }
}
