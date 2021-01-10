using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using System.Text.RegularExpressions;

public class DialogueManager : MonoBehaviour
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
    private Color originalColor;

    public AudioSource ClickSound;
    public AudioSource SplashSound;

    public GameObject particleContainer;

    public void EnableDialogue()
    {
        characterName = EventSystem.current.currentSelectedGameObject.name;
        nameBox = dialogueInterface.transform.GetChild(2).GetChild(2).gameObject;

        switch (characterName)
        {
            case "Sylvio":
                if (CanTalk.toMermaid == true)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(0).gameObject;
                    portrait.SetActive(true);
                    SplashSound.Play();
                    if (Inventory.MermaidHearts == 0)
                    {
                        particleContainer.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Sylvio_Intro.txt");
                        Inventory.MermaidHearts++;
                    }
                    else if (Inventory.MermaidHearts >= 3 && CanTalk.halfEventMermaid == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Sylvio_Halfway.txt");
                        CanTalk.halfEventMermaid = true;
                    }
                    else if (Inventory.MermaidHearts >= 5 && CanTalk.halfEventMermaid == true && CanTalk.finalEventMermaid == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Sylvio_Final.txt");
                        CanTalk.finalEventMermaid = true;
                    }
                    else if (Inventory.MermaidHearts >= 1)
                    {
                        GetPun("Sylvio", 5);
                    }
                    CanTalk.toMermaid = false;
                }
                break;
            case "Mizzen":
                if (CanTalk.toMate == true)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(1).gameObject;
                    portrait.SetActive(true);
                    ClickSound.Play();
                    if (Inventory.MateHearts == 0)
                    {
                        particleContainer.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Mate_Intro.txt");
                        Inventory.MateHearts++;
                    }
                    else if (Inventory.MateHearts >= 3 && CanTalk.halfEventMate == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Mate_Halfway.txt");
                        CanTalk.halfEventMate = true;
                    }
                    else if (Inventory.MateHearts >= 5 && CanTalk.halfEventMate == true && CanTalk.finalEventMate == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Mate_Final.txt");
                        CanTalk.finalEventMate = true;
                    }
                    else if (Inventory.MateHearts >= 1)
                    {
                        GetPun("Mate", 3);
                    }
                    CanTalk.toMate = false;
                }
                break;
            case "Madge":
                if (CanTalk.toMadge == true)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(2).gameObject;
                    portrait.SetActive(true);
                    ClickSound.Play();
                    if (Inventory.MadgeHearts == 0)
                    {
                        particleContainer.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Madge_Intro.txt");
                        Inventory.MadgeHearts++;
                    }
                    else if (Inventory.MadgeHearts >= 3 && CanTalk.halfEventMadge == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Madge_Halfway.txt");
                        CanTalk.halfEventMate = true;
                    }
                    else if (Inventory.MadgeHearts >= 5 && CanTalk.halfEventMadge == true && CanTalk.finalEventMadge == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Madge_Final.txt");
                        CanTalk.finalEventMate = true;
                    }
                    else if (Inventory.MadgeHearts >= 1)
                    {
                        GetPun("Madge", 5);
                    }
                }
                break;
            case "Polly":
                if (CanTalk.toParrot == true)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(3).gameObject;
                    portrait.SetActive(true);
                    ClickSound.Play();
                    if (Inventory.ParrotHearts == 0)
                    {
                        particleContainer.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Parrot_Intro.txt");
                        Inventory.ParrotHearts++;
                    }
                    else if (Inventory.ParrotHearts >= 3 && CanTalk.halfEventParrot == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Parrot_Halfway.txt");
                        CanTalk.halfEventParrot = true;
                    }
                    else if (Inventory.ParrotHearts >= 5 && CanTalk.halfEventParrot == true && CanTalk.finalEventParrot == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Parrot_Final.txt");
                        CanTalk.finalEventParrot = true;
                    }
                    else if (Inventory.ParrotHearts >= 1)
                    {
                        GetPun("Parrot", 5);
                    }
                    CanTalk.toParrot = false;
                }
                break;
            case "Sir Jay":
                if (CanTalk.toPrivateer == true)
                {
                    dialogueInterface.SetActive(true);
                    portrait = dialogueInterface.transform.GetChild(1).GetChild(4).gameObject;
                    portrait.SetActive(true);
                    ClickSound.Play();
                    if (Inventory.PrivateerHearts == 0)
                    {
                        particleContainer.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Jay_Intro.txt");
                        Inventory.PrivateerHearts++;
                    }
                    else if (Inventory.PrivateerHearts >= 3 && CanTalk.halfEventPrivateer == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Jay_Halfway.txt");
                        CanTalk.halfEventMate = true;
                    }
                    else if (Inventory.PrivateerHearts >= 5 && CanTalk.halfEventPrivateer == true && CanTalk.finalEventPrivateer == false)
                    {
                        particleContainer.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                        ReadDialogue("Jay_Final.txt");
                        CanTalk.finalEventPrivateer = true;
                    }
                    else if (Inventory.PrivateerHearts >= 1)
                    {
                        GetPun("Jay", 5);
                    }
                    CanTalk.toPrivateer = false;
                }
                break;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        originalColor = dialogueInterface.transform.GetChild(0).GetComponent<Image>().color;
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
        int i;

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
            sentence = Regex.Replace(sentence, "(?:Y\\/N)", Inventory.PlayerName, RegexOptions.IgnorePatternWhitespace);
        }

        // check for name flags at the beginnings of sentences
        if (sentence[0] == ':')
        {
            i = 1;
            while (sentence[i] != ':')
            {
                i++;
            }
            nameText.text = sentence.Substring(1, i-1);
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

        dialogueInterface.transform.GetChild(0).GetComponent<Image>().color = originalColor;
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

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void GetPun(string prefix, int numPuns)
    {
        int pun = randm.Next(1, numPuns + 1);
        string puntxt = prefix + "_Puns" + pun + ".txt";
        ReadDialogue(puntxt);
    }
}
