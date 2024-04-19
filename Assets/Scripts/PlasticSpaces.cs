using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticSpaces : MonoBehaviour, ISpace
{
     public void OnSpaceBehaviour(Player player) {
        GameManager gameManager = GetComponent<GameManager>();

        player.ResetFishAmount();
    }   

    public void SpaceSprite(){

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
