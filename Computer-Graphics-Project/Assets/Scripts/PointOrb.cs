using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOrb : MonoBehaviour
{
    public AudioSource beep;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        beep = GetComponent<AudioSource>();
        //Destroy the senzu
        if (collision.tag == "Player")
        {
            beep.Play();
            GameManager.playerScore += 100;
            GameManager.scoreOrbsRemaining=GameManager.scoreOrbsRemaining-1;
            
            Destroy(gameObject);
            if(GameManager.scoreOrbsRemaining == 0)
            {
                GameManager.Win = true;
            }
        }

    }
}