using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChildActivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        int randomlyChosenIndex = rand.Next(0, transform.childCount);

        transform.GetChild(randomlyChosenIndex).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
