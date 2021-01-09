using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLoot : MonoBehaviour
{
    public Text shellCount, goldCount, gemCount, spiceCount, rumCount;

    void Update()
    {
        shellCount.text = "" + Inventory.Shells;
        goldCount.text = "" + Inventory.Doubloons;
        gemCount.text = "" + Inventory.Gems;
        spiceCount.text = "" + Inventory.Spices;
        rumCount.text = "" + Inventory.Rum;
    }

}
