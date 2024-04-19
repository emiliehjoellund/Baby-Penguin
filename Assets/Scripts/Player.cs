using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int turnsLost = 0;
   private int fishAmount;

    public void LoseTurn()
    {
        turnsLost++;
    }

    public void AddFishToPlayer(){
        fishAmount++;
    }

    public void ResetFishAmount(){
        GameManager gameManager = GetComponent<GameManager>();
        gameManager.AddFishToPond(fishAmount);
        fishAmount = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
