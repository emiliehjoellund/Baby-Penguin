using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickySpaces : MonoBehaviour, IStickySpace
{

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            StickySpace(player);
        }
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
