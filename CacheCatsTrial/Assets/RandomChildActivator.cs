using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChildActivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Random random = new Random();
        int randomlyChosenIndex = random.Next(0, transform.childCount);

        transform.GetChild(randomlyChosenIndex).setActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
