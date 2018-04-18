using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour, IPointerClickHandler
{
    public GameObject player;
    public void OnPointerClick(PointerEventData eventData)
    {
        //DontDestroyOnLoad(player);
        SceneManager.LoadScene("Lake");
    }
}
