using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject MainMenuScreen;
    public GameObject HighScore;
    // Start is called before the first frame update
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
   

    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void HighScoreScreen()
    {
        MainMenuScreen.SetActive(false);
        HighScore.SetActive(true);

    }
    public void BackButton()
    {
        HighScore.SetActive(false);
        MainMenuScreen.SetActive(true);
        

    }
}
