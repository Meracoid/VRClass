using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MoreInfoButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public string url;
    public GameObject box;
    public Material change;
    public Material trans;
    public GameObject player;
    public string destination;
    public GameObject otherText;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerClassHandler.file = url;
        //DontDestroyOnLoad(player);
        SceneManager.LoadScene(destination);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (otherText.GetComponent<TextMesh>().color != Color.clear)
        {
            box.GetComponent<Renderer>().material = change;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        box.GetComponent<Renderer>().material = trans;
    }
}
