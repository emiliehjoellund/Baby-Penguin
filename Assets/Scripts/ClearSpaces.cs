using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClearSpaces : MonoBehaviour, ISpace
{
    public void OnSpaceBehaviour(Player player) {
        player.AddFishToPlayer();
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
