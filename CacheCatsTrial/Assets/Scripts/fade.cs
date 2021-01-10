using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    public GameObject element;
    public float speed;


    void OnEnable()
    {
        StartCoroutine(fadeElement(speed));
    }

    public IEnumerator fadeElement(float speed)
    {
        var tempColor = element.GetComponent<Image>().color;
        while (element.GetComponent<Image>().color.a < .729f)
        {
            tempColor = new Color(tempColor.r, tempColor.g, tempColor.b, tempColor.a + (Time.deltaTime / speed));
            element.GetComponent<Image>().color = tempColor;
            yield return null;
            // Debug.Log("mario loading");
        }


    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
