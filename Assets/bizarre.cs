using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bizarre : MonoBehaviour
{
    bool clicked;
    public GameObject mika;

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
        }

    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            clicked = false;
        }
        if (clicked)
        {
            mika.SetActive(true);
        }
    }
}