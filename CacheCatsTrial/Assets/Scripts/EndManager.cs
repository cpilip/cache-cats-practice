using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    //public Image element;
        void OnEnable()
        {
            StartCoroutine("fadeEnd");


        }

    public IEnumerator fadeEnd()
    {
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            this.GetComponent<Image>().color = new Color(0, 0, 0, i);
            yield return null;
        }

        transform.parent.GetChild(2).gameObject.SetActive(true);

        // Should go through outro dialogue here
        // Once done, disable dialogue and start the following coroutine
        yield return StartCoroutine("fadeText");

    }

    public IEnumerator fadeText()
    {
        transform.parent.GetChild(1).gameObject.SetActive(true);

        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
           // Debug.Log(transform.parent.GetChild(1).name);
            transform.parent.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, i);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        transform.parent.GetChild(3).gameObject.SetActive(true);

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    
    
}
