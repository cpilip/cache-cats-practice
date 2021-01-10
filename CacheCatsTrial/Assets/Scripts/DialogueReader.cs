using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DialogueReader : MonoBehaviour
{
    public Dialogue dialogue;
    string myFilePath;

    public void ReadDialogue(string fileName)
    {
        myFilePath = Application.dataPath + "/" + fileName;

        dialogue.sentences = File.ReadAllLines(myFilePath);
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
