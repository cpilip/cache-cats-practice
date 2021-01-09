using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Queue<string> sentences;

    public GameObject dialogueInterface;

    private GameObject portrait;

    public void EnableDialogue()
    {
        dialogueInterface.SetActive(true);
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Sylvia":
                portrait = dialogueInterface.transform.GetChild(1).GetChild(0).gameObject;
                portrait.SetActive(true);
                break;
            case "First Mate":
                portrait = dialogueInterface.transform.GetChild(1).GetChild(1).gameObject;
                portrait.SetActive(true);
                break;
            case "Token Female":
                portrait = dialogueInterface.transform.GetChild(1).GetChild(2).gameObject;
                portrait.SetActive(true);
                break;
            case "Parrot":
                portrait = dialogueInterface.transform.GetChild(1).GetChild(3).gameObject;
                portrait.SetActive(true);
                break;
            
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            DisableDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        /* Debug.Log(sentence.Substring(0, 5) + "[EOL]");
        if (sentence.Substring(0,5).Equals("name:"))
        {
            int i = 7;
            while (sentence[i] != ' ')
            {
                Debug.Log("[" + sentence[i] + "]");
                i++;
            }
            nameText.text = sentence.Substring(6, i);
            dialogueText.text = sentence.Substring(i + 1);
        }
        else */
        dialogueText.text = sentence;
    }

    public void DisableDialogue()
    {
        portrait.SetActive(false);
        dialogueInterface.SetActive(false);
    }
}
