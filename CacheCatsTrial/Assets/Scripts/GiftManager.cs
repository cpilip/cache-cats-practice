using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

public class GiftManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Queue<string> sentences;

    public GameObject dialogueInterface;
    private GameObject nameBox;

    private GameObject portrait;
    private string characterName;

    public Dialogue dialogue;
    string myFilePath;

    private System.Random randm = new System.Random();

    public void GiveGift()
    {
        characterName = EventSystem.current.currentSelectedGameObject.name;
        nameBox = dialogueInterface.transform.GetChild(2).GetChild(2).gameObject;

        switch (characterName)
        {
            case "Gift Shell":
                if (CanGift.toMermaid == true && Inventory.Shells > 0)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(0).gameObject;
                    portrait.SetActive(true);
                    if (Inventory.MermaidHearts == 0)
                    {
                        ReadDialogue("Sylvia_Intro.txt");
                        Inventory.MermaidHearts++;
                    }
                    CanGift.toMermaid = false;
                }
                break;
            case "Gift Doubloon":
                if (CanGift.toMate == true && Inventory.Doubloons > 0)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(1).gameObject;
                    portrait.SetActive(true);
                    int thanks = randm.Next(1, 4);
                    string thanktxt = "Mate_Thanks" + thanks + ".txt";
                    ReadDialogue(thanktxt);
                }
                break;
            case "Gift Gem":
                if (CanGift.toFemale == true && Inventory.Gems > 0)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(2).gameObject;
                    portrait.SetActive(true);
                }
                break;
            case "Gift Rum":
                if (CanGift.toParrot == true && Inventory.Rum > 0)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(3).gameObject;
                    portrait.SetActive(true);
                    if (Inventory.ParrotHearts == 0)
                    {
                        ReadDialogue("Parrot_Intro.txt");
                        Inventory.ParrotHearts++;
                    }
                    CanGift.toParrot = false;
                }
                break;
            case "Gift Spices":
                if (CanGift.toPrivateer == true && Inventory.Spices > 0)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(4).gameObject;
                    portrait.SetActive(true);
                    if (Inventory.PrivateerHearts == 0)
                    {
                        ReadDialogue("Jay_Intro.txt");
                        Inventory.PrivateerHearts++;
                    }
                    else if (Inventory.PrivateerHearts >= 1)
                    {
                        int pun = randm.Next(1, 6);
                        string puntxt = "Jay_Puns" + pun + ".txt";
                        ReadDialogue(puntxt);
                    }
                    CanGift.toPrivateer = false;
                }
                break;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
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

        nameBox.SetActive(true);

        // Check if sentence include "your name" tag and replace with your name
        if (sentence.Contains("Y/N"))
        {
            int len = sentence.Length, i;
            for (i = 0; i < len - 4; i++)
            {
                if (sentence.Substring(i, i + 3) == "Y/N")
                {
                    break;
                }
            }
            sentence = sentence.Substring(0, i) + Inventory.PlayerName + sentence.Substring(i + 3);
        }

        // check for name flags at the beginnings of sentences
        if (sentence[0] == ':')
        {
            int i = 1;
            while (sentence[i] != ':')
            {
                i++;
            }
            nameText.text = sentence.Substring(1, i - 1);
            // if name is empty, disable name box to imply narrator speech
            if (nameText.text == " ")
            {
                nameBox.SetActive(false);
            }
            else
            {
                nameBox.SetActive(true);
            }
            // stop coroutines to prevent overlap of two letter typers when clicking through too fast
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence.Substring(i - 1 + 2)));
        }
        else
        {
            // if no name flag, reset name to characterName
            // this allows you to not have to reflag every line
            nameText.text = characterName;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
    }

    public void DisableDialogue()
    {
        portrait.SetActive(false);
        dialogueInterface.SetActive(false);
    }

    public void ReadDialogue(string fileName)
    {
        myFilePath = Application.dataPath + "/Dialogue/" + fileName;

        dialogue.sentences = File.ReadAllLines(myFilePath);
        dialogue.name = characterName;

        StartDialogue(dialogue);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
}
