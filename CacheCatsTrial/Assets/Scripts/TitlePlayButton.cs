using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitlePlayButton : MonoBehaviour
{
    public InputField input;

    public void StartGame()
    {
        string name = input.text;
        if (!string.IsNullOrWhiteSpace(name))
        {
            Inventory.PlayerName = name;
            SceneManager.LoadScene("Hub");
        }
        
    }

    public void StartDebugMiniGame()
    {
        SceneManager.LoadScene("DebugMiniGame");
    }

    public void BackToHub()
    {
        SceneManager.LoadScene("Hub");
    }
}
