using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistenceTimer : MonoBehaviour
{

    public float time_needed;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("OnEndOfTimer", time_needed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEndOfTimer()
    {
        // Do whatever.
        Debug.Log("End of " + time_needed + " second(s) timer!");
    }
}
