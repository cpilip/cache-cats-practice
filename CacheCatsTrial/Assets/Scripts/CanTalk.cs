using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CanTalk
{
    private static bool mermaid, mate, female, privateer, parrot;

    public static bool toMermaid
    {
        get
        {
            return mermaid;
        }
        set
        {
            mermaid = value;
        }
    }

    public static bool toMate
    {
        get
        {
            return mate;
        }
        set
        {
            mate = value;
        }
    }

    public static bool toFemale
    {
        get
        {
            return female;
        }
        set
        {
            female = value;
        }
    }

    public static bool toPrivateer
    {
        get
        {
            return privateer;
        }
        set
        {
            privateer = value;
        }
    }

    public static bool toParrot
    {
        get
        {
            return parrot;
        }
        set
        {
            parrot = value;
        }
    }
}
