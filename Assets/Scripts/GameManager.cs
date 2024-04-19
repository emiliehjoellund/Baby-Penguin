using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int[] fishCount = new int[4];
    private int[] playerPosition = new int[4];
    private int fishInPond = 12;

    public void AddFishToPond(int amount)
    {
        fishInPond += amount;
    }


    public void RemoveFishFromPond(int amount)
    {
        fishInPond -= amount;
    }

    public void AddFishToPlayer(int player, int amount)
    {
        fishCount[player] += amount;
    }

    public void RemoveFishFromPlayer(int player, int amount)
    {
        fishCount[player] -= amount;
    }


    public List<Spaces> Spaces = new List<Spaces>();



}
