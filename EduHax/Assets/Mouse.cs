using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Mouse : MonoBehaviour
{
   public Texture2D cursorTexture;
  public CursorMode cursorMode = CursorMode.Auto;
   public Vector2 hotSpot = Vector2.zero;
   public static Button isPressed;
    float CurrentRotation;
    void Start()
    {
       Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        CurrentRotation = transform.rotation.y;
        isPressed = GameObject.Find("GrayButton").GetComponent<Button>();
     
    }

    void Update()
    {
      
    }

   void OnPress()
    {
          if (isPressed.isPresssed)
        {
            transform.Rotate(0, CurrentRotation+50, 0);

            Debug.Log(" yes");
        }
        else{
            Debug.Log("NO");
            transform.Rotate(0, CurrentRotation - 50, 0);
        }
    }
  


}
