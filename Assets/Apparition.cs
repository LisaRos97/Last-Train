using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apparition : MonoBehaviour
{
    public GameObject objet1;
    public GameObject objet2;
    public GameObject objet3;
    public GameObject objet4;

    public void Start()
    {
        objet1.SetActive(false);
        objet2.SetActive(false);
        objet3.SetActive(false);
        objet4.SetActive(false);
    }
           


          void OnMouseOver()
          
        {
            objet1.SetActive(true);
        objet2.SetActive(true);
        objet3.SetActive(true);
        objet4.SetActive(true);
    }

       // void OnMouseExit()
        //{
           // mika.SetActive(false);
        //}
    
     
}

   