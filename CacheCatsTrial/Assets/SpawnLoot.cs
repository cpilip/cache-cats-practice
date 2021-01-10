using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoot : MonoBehaviour
{
    private System.Random rand;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
        InvokeRepeating("NewItem", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void NewItem()
    {
        // Spawn a new random item (prefab specified in editor).
        int new_object_type = rand.Next(0, 5);
        GameObject createdObject = Instantiate(prefab, transform.position, transform.rotation);
        Pickup component = createdObject.GetComponent(typeof(Pickup)) as Pickup;
        component.loot_type = new_object_type;
    }
}
