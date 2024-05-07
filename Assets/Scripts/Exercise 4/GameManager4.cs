using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager4 : MonoBehaviour
{
    // public Text deathCounterText;
    public GameObject checkpoint;

    private int deathCount = 0;

    void Start()
    {
       checkpoint = GameObject.FindGameObjectWithTag("Checkpoint");
    }

    public void RespawnPlayer(PlayerController4 player)
    {   
        Debug.Log("Respawn");
        // deathCount++;
        // deathCounterText.text = "Deaths: " + deathCount.ToString();
        player.transform.position = checkpoint.transform.position;         
          
    }
}
