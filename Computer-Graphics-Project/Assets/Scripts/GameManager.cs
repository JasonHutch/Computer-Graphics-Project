using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int playerScore = 0;
    public static int scoreOrbsRemaining = 18;
    public Text Score;
    public float timer = 0;
    public Text startText; // used for showing countdown from 3, 2, 1 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        startText.text = minutes + " " + seconds;
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
    public static void Winner()
    {
        SceneManager.LoadScene("Winner");
        Debug.Log("Winner screen shown");
    }
}
