using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int fishInPond = 12;

    public void AddFishToPond(int amount)
    {
        fishInPond += amount;
    }


    public void RemoveFishFromPond(int amount)
    {
        fishInPond -= amount;
    }

    public List<Spaces> Spaces = new List<Spaces>();

    // baby penguin

}
