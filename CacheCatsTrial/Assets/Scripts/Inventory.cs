using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inventory
{
    private static int shells, doubloons, gems, spices, rum;

    // relationship levels
    private static int mermaidHearts, mateHearts, femaleHearts, privateerHearts, parrotHearts;

    private static string playerName;

    public static int Shells
    {
        get
        {
            return shells;
        }
        set
        {
            shells = value;
        }
    }

    public static int Doubloons
    {
        get
        {
            return doubloons;
        }
        set
        {
            doubloons = value;
        }
    }

    public static int Gems
    {
        get
        {
            return gems;
        }
        set
        {
            gems = value;
        }
    }

    public static int Spices
    {
        get
        {
            return spices;
        }
        set
        {
            spices = value;
        }
    }

    public static int Rum
    {
        get
        {
            return rum;
        }
        set
        {
            rum = value;
        }
    }

    // relationships

    public static int MermaidHearts
    {
        get
        {
            return mermaidHearts;
        }
        set
        {
            mermaidHearts = value;
        }
    }

    public static int MateHearts
    {
        get
        {
            return mateHearts;
        }
        set
        {
            mateHearts = value;
        }
    }

    public static int FemaleHearts
    {
        get
        {
            return femaleHearts;
        }
        set
        {
            femaleHearts = value;
        }
    }

    public static int PrivateerHearts
    {
        get
        {
            return privateerHearts;
        }
        set
        {
            privateerHearts = value;
        }
    }

    public static int ParrotHearts
    {
        get
        {
            return parrotHearts;
        }
        set
        {
            parrotHearts = value;
        }
    }

    public static string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            playerName = value;
        }
    }
}
