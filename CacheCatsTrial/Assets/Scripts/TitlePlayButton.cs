using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitlePlayButton : MonoBehaviour
{
    public InputField input;
    public GameObject credits;
    public GameObject element;

    private Color originalColor;

    public void StartGame()
    {
        string name = input.text;
        if (!string.IsNullOrWhiteSpace(name))
        {
            Inventory.PlayerName = name;
            SceneManager.LoadScene("Hub");
        }
        
    }

    public void ShowCredits()
    {
        StartCoroutine("fadeElement");
        credits.SetActive(true);
    }

    public void CloseCredits()
    {
        //StartCoroutine("fadeElement");
        element.GetComponent<Image>().color = originalColor;
        credits.SetActive(false);
    }

    public IEnumerator fadeElement()
    {
        float speed = 1;
        var tempColor = element.GetComponent<Image>().color;
        originalColor = tempColor;
        while (element.GetComponent<Image>().color.a < .729f)
        {
            tempColor = new Color(tempColor.r, tempColor.g, tempColor.b, tempColor.a + (Time.deltaTime / speed));
            element.GetComponent<Image>().color = tempColor;
            yield return null;
            // Debug.Log("mario loading");
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
