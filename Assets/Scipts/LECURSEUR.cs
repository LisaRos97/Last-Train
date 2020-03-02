using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LECURSEUR : MonoBehaviour
{


    public Texture2D MouseDefaut;
    public Texture2D CLICK ;
    public CursorMode curMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(MouseDefaut, hotSpot, curMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if (gameObject.tag == "CLICK")
        {
            Cursor.SetCursor(CLICK, hotSpot, curMode);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(MouseDefaut, hotSpot, curMode);
    }
   

}


