using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabled {
    private bool isDisabled;

    public bool disabled
    {
        get
        {
            return isDisabled;
        }
        set
        {
            isDisabled = value;
        }
    }
}
