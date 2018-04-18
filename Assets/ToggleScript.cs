using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleScript : MonoBehaviour, IPointerClickHandler
{
    public List<GameObject> objects;
    public Material mat;
    public Material matClear;
    private bool toggle;

    public void Start()
    {
        toggle = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (toggle)
        {
            for (int j = 0; j < objects.Count; j++)
            {
                objects[j].GetComponent<Renderer>().material = matClear;
            }
        }
        else {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].GetComponent<Renderer>().material = mat;
            }
        }
        toggle = !toggle;
    }

    
}
