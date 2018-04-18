using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class FileHandler : MonoBehaviour
{

    public GameObject box;
	// Use this for initialization
	void Start () {
       Texture tex = Resources.Load(PlayerClassHandler.file) as Texture;
       box.GetComponent<Renderer>().material.mainTexture = tex;
	}
	
}
