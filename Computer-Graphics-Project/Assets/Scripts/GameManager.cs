using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int playerScore = 0;
    public Text Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score\n" + playerScore.ToString();

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
