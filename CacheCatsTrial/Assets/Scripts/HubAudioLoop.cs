using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubAudioLoop : MonoBehaviour
{
    public GameObject audiocontainer;
    private GameObject audioIntro;
    private GameObject audioLoop;

    private void Start()
    {
        audioIntro = audiocontainer.transform.GetChild(0).gameObject;
        audioLoop = audiocontainer.transform.GetChild(1).gameObject;
    
        audioIntro.GetComponent<AudioSource>().Play();

        audioLoop.GetComponent<AudioSource>().PlayDelayed(audioIntro.GetComponent<AudioSource>().clip.length);
    }
}
