using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClassHandler{
    private static string fileLoad;

    public static string file
    {
        get
        {
            return fileLoad;
        }
        set
        {
            fileLoad = value;
        }
    }
}
