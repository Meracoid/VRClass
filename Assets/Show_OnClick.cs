using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Show_OnClick : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

    private bool isShown;
    public GameObject text; //info text
    public GameObject box;
    public GameObject moreInfo;
    public Material trans;
    public Material change;

	// Use this for initialization
	void Start () {
        isShown = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!isShown)
        {
            text.GetComponent<TextMesh>().color = Color.clear;
            moreInfo.GetComponentInChildren<TextMesh>().color = Color.clear;
        } else
        {
            text.GetComponent<TextMesh>().color = Color.white;
            moreInfo.GetComponentInChildren<TextMesh>().color = Color.white;
        }
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        isShown = !isShown;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        box.GetComponent<Renderer>().material = change;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        box.GetComponent<Renderer>().material = trans;
    }
}
