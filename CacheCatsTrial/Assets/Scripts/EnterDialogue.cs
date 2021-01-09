using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDialogue : MonoBehaviour
{
    public GameObject dialogueInterface;

    public void EnableDialogue()
    {
        dialogueInterface.SetActive(true);
    }
}
