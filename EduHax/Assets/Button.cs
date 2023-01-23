using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioSource VoiceOver;
  public bool isPresssed = false;
    public Transform Hammer;
    
    public void OnClick()
    {  gameObject.SetActive(false);
        VoiceOver.Play();
        isPresssed = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnMouseDown");
        Hammer.Rotate(Hammer.rotation.x, Hammer.rotation.y, Hammer.rotation.z + 90);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnMouseUp");
        Hammer.Rotate(Hammer.rotation.x, Hammer.rotation.y, Hammer.rotation.z - 90);
    }


}
