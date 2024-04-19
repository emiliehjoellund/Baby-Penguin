using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticSpaces : MonoBehaviour, ISpace
{
     private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            PlasticSpace(player);
        }
    }
    public void PlasticSpace(Player player)
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
