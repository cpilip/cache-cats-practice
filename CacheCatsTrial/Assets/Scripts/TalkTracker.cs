using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkTracker : MonoBehaviour
{
    void OnEnable()
    {
        CanTalk.toMermaid = true;
        CanTalk.toMate = true;
        CanTalk.toFemale = true;
        CanTalk.toPrivateer = true;
        CanTalk.toParrot = true;

        CanGift.toMermaid = true;
        CanGift.toMate = true;
        CanGift.toFemale = true;
        CanGift.toPrivateer = true;
        CanGift.toParrot = true;
    }
}
