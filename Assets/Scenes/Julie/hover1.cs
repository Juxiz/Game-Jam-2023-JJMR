using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hover1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image image;
    public static hover1 snapping;
    public Vector3 snapposition;
    public float minafstand;
    public void OnPointerEnter(PointerEventData eventData)
    {
         Debug.Log("overother");
        //image.color = new Color32(255, 255, 255, 170);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("not overother");
        //image.color = new Color32(255, 255, 255, 255);
    }
    void Update()
    {
        RectTransform rt = GetComponent<RectTransform>();
        Vector3[] corners = new Vector3[4];
        rt.GetWorldCorners(corners);

        Vector2 average = Vector3.zero;
        for (int i = 0; i < 4; i++)
        {
            average += (Vector2)corners[i];
        }
        average /= 4;
        snapposition = average;

        float distance = Vector3.Distance(average, (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Debug.Log($"average: {average}, STWP: {(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition)}, distance: {distance}");

        if (distance < minafstand)
        {
            snapping = this;
        }
        else if (snapping == this)
        {
            snapping = null;
            
        }
        Debug.Log("snapping:" + snapping);
    }

}
