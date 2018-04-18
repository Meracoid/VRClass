using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Show_OnClickVideo : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    public string url;
    public GameObject box;
    public Material change;
    public Material trans;
    public GameObject player;
    public string destination;

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerClassHandler.file = url;
        //DontDestroyOnLoad(player);
        SceneManager.LoadScene(destination);
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
