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
}
