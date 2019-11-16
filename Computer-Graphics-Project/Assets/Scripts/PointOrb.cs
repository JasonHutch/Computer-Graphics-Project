using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOrb : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)

    {
        //Destroy the senzu
        if (collision.tag == "Player")
        {
            GameManager.playerScore += 100;
            GameManager.scoreOrbsRemaining=GameManager.scoreOrbsRemaining-1;
            Destroy(gameObject);
            if(GameManager.scoreOrbsRemaining == 0)
            {
                GameManager.Winner();
            }
        }

    }
}