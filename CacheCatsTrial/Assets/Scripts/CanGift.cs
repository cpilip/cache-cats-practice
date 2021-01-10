using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CanGift
{
    private static bool mermaid, mate, madge, privateer, parrot;

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

    public static bool toMadge
    {
        get
        {
            return madge;
        }
        set
        {
            madge = value;
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
