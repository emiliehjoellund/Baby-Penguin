using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSpaces : MonoBehaviour, ISpace
{
    
     public void OnSpaceBehaviour(Player player) {
        player.fishAmount++;
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
