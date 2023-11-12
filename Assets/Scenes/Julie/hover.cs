using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Outline outline;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Debug.Log("over");
        //GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("not over");
        //GetComponent<Outline>().enabled = false;
    }

    // Start is called before the first frame update
    void OnPointerEnter()
    {
       
    }

    // Update is called once per frame
    void OnPointerExit()
    {
        
    }
}
