using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int loot_type;

    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        // Set the sprite according to loot type.
        // I know I should use an enum, but I'd rather get it done quick.
        renderer = GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Icons");

        renderer.sprite = (Sprite) sprites[loot_type];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("DEBUG: Hit the pickup.");

        // Increment the relevant loot counter.
        switch (loot_type)
        {
            case 0:
                Debug.Log("Inventory Rum was: " + Inventory.Rum);
                Inventory.Rum = Inventory.Rum + 1;
                Debug.Log("Inventory Rum is: " + Inventory.Rum);
                break;
            case 1:
                Inventory.Shells = Inventory.Shells + 1;
                break;
            case 2:
                Inventory.Doubloons = Inventory.Doubloons + 1;
                break;
            case 3:
                Inventory.Spices = Inventory.Spices + 1;
                break;
            case 4:
                Inventory.Gems = Inventory.Gems + 1;
                break;
        }

        // Destroy the pickup.
        Destroy(gameObject);
    }
}
