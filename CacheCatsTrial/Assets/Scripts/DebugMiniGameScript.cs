using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMiniGameScript : MonoBehaviour
{
    // TODO: puns, gifts, debug minigame
    public void GiveRum()
    {
        Inventory.Rum++;
        Debug.Log("Rum: " + Inventory.Rum);
    }
    public void GiveShells()
    {
        Inventory.Shells++;
        Debug.Log("Shells: " + Inventory.Shells);
    }
    public void GiveDoubloons()
    {
        Inventory.Doubloons++;
        Debug.Log("Gold: " + Inventory.Doubloons);
    }
    public void GiveGems()
    {
        Inventory.Gems++;
        Debug.Log("Gems: " + Inventory.Gems);
    }
    public void GiveSpices()
    {
        Inventory.Spices++;
        Debug.Log("Spices: " + Inventory.Spices);
    }
}
