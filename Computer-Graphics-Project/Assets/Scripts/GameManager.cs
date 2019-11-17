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
    public static bool Win = false;
    public int bonus = 0;
    public float timer = 0;
    public Text startText; // used for showing countdown from 3, 2, 1 
    public Text scoreText;
    public Text bonusText;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        if(Win){
            bonus = (int) Mathf.Floor((1/(timer % 60)) * 10000) + (18 - scoreOrbsRemaining) * 10;
            bonusText.text = "Bonus: " + bonus;
            Winner();
        }else{
            bonus = 0;
        }
        
        bonusText.text = "Bonus: " + bonus;
        startText.text = "Time: " + minutes + ":" + seconds;
        scoreText.text = "Score: " + playerScore.ToString();
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
