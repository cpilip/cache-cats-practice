using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CanTalk
{
    private static bool mermaid, mate, madge, privateer, parrot;
    private static bool halfMermaid, halfMate, halfMadge, halfPrivateer, halfParrot;
    private static bool finalMermaid, finalMate, finalMadge, finalPrivateer, finalParrot;

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

    public static bool halfEventMermaid
    {
        get
        {
            return halfMermaid;
        }
        set
        {
            halfMermaid = value;
        }
    }

    public static bool halfEventMate
    {
        get
        {
            return halfMate;
        }
        set
        {
            halfMate = value;
        }
    }

    public static bool halfEventMadge
    {
        get
        {
            return halfMadge;
        }
        set
        {
            halfMadge = value;
        }
    }

    public static bool halfEventPrivateer
    {
        get
        {
            return halfPrivateer;
        }
        set
        {
            halfPrivateer = value;
        }
    }

    public static bool halfEventParrot
    {
        get
        {
            return halfParrot;
        }
        set
        {
            halfParrot = value;
        }
    }

    public static bool finalEventMermaid
    {
        get
        {
            return finalMermaid;
        }
        set
        {
            finalMermaid = value;
        }
    }

    public static bool finalEventMate
    {
        get
        {
            return finalMate;
        }
        set
        {
            finalMate = value;
        }
    }

    public static bool finalEventMadge
    {
        get
        {
            return finalMadge;
        }
        set
        {
            finalMadge = value;
        }
    }

    public static bool finalEventPrivateer
    {
        get
        {
            return finalPrivateer;
        }
        set
        {
            finalPrivateer = value;
        }
    }

    public static bool finalEventParrot
    {
        get
        {
            return finalParrot;
        }
        set
        {
            finalParrot = value;
        }
    }
}
