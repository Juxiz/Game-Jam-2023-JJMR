using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeRectTransform : MonoBehaviour
{
    private RectTransform rt;
    private Vector2 startPosition;
    [Range(0.5f, 100f)]
    public float strength = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        startPosition = rt.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPostion = new Vector2(Random.Range(-strength, strength), Random.Range(-strength, strength)) + startPosition;
        rt.anchoredPosition = newPostion;
    }
}
