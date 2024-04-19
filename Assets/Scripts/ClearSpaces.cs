using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSpaces : MonoBehaviour, ISpace
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            ClearSpace(player);
        }
    }

    public void ClearSpace(Player player)
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
