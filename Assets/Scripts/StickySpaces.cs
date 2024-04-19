using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickySpaces : MonoBehaviour, IStickySpace
{

    public void OnPlayerEnter(Player player)
    {
        StickySpace(player);
    }

    public void StickySpace(Player player)
    {
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
