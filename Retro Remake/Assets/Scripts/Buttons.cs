using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    { 
        Application.Quit();
        Debug.Log("Application quit");
    }
}
