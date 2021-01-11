using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text.RegularExpressions;

public class EndManager : MonoBehaviour
{
    public AudioSource music;

    public Text nameText;
    public Text dialogueText;

    public Queue<string> sentences;

    public GameObject dialogueInterface;

    public Dialogue dialogue;
    string myFilePath;

    private AudioSource[] allAudioSources;
  
    void Awake()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

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
        EnableDialogue();

        

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

    public void EnableDialogue()
    {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }

        dialogueInterface.SetActive(true);
        ReadDialogue("End_Text.txt");
        music.Play();
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
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

        
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        
    }

    public void DisableDialogue()
    {
        dialogueInterface.SetActive(false);
        StartCoroutine("fadeText");
    }

    public void ReadDialogue(string fileName)
    {


        string file = ("Dialogue/" + fileName).Substring(0, ("Dialogue/" + fileName).Length - 4);
        dialogue.sentences = Resources.Load<TextAsset>(file).text.Split("\n"[0]);
        dialogue.name = " ";

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

