using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePlayButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Hub");
    }
}
