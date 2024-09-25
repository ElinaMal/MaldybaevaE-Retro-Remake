using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int currentScore;
    public TMPro.TMP_Text scoreText;

    public bool gameWon;
    public int objectsDestroyed;


    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + currentScore.ToString());

        if (objectsDestroyed >= 80)
        {
            gameWon = true;
        }
        else
        {
            gameWon = false;
        }

        if (gameWon)
        {
            SceneManager.LoadScene("Level 2");
        }

        if (objectsDestroyed >= 82)
        {
            SceneManager.LoadScene("You Win");
        }
    }
}
