using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Scene_3");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void QuitScene()
    {
        Application.Quit();
    }
}