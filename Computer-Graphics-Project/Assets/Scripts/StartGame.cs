using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public float timer=0;
    public Text startText; // used for showing countdown from 3, 2, 1 


    void Update()
    {
        timer += Time.deltaTime;
        

        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        
        startText.text = minutes + " " + seconds;
        
    }
}