using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Otherdragndrop : MonoBehaviour, /*IPointerDownHandler,*/ IPointerEnterHandler, IPointerExitHandler
{
    public bool clicked = false;
    public bool hoverd = false;
    public bool outlined = false;
    public bool raycastable = true;
    public bool held = false;
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log("click");
    //    if (clicked)
    //    {
    //        clicked = false;

    //        GetComponent<Renderer>().enabled = true;

    //    }
    //    else
    //    {
    //        clicked = true;
    //        GetComponent<Renderer>().enabled = false;
    //    }
    //}

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverd = true;
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverd = false;
        GetComponent<Outline>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clicked = true;
        }
        else
        {
            clicked = false;
        }
        if (clicked && hoverd && !held)
        {
            raycastable = false;
            GetComponent<Image>().raycastTarget = false;
            held = true;
        }
        else if (clicked && held)
        {
            raycastable = true;
            GetComponent<Image>().raycastTarget = true;
            held = false;

        }
        if (held)
        {
            if (hover1.snapping)
            {
                transform.position = hover1.snapping.snapposition;
            }
            else
            {
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

        }

    }
}
