using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject box;
    private bool isPlaying;
    public AudioSource audio;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isPlaying)
        {
            box.GetComponent<VideoPlayer>().Pause();
            isPlaying = false;
        }
        else
        {
            box.GetComponent<VideoPlayer>().Play();
            isPlaying = true;
        }
    }

    // Use this for initialization
    void Start () {
        box.GetComponent<VideoPlayer>().clip = Resources.Load(PlayerClassHandler.file) as VideoClip;
        isPlaying = false;
        audio.clip = Resources.Load(PlayerClassHandler.file) as AudioClip;
	}
	
    
}
