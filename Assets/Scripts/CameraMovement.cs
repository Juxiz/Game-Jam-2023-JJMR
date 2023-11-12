using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    private float maxX = 10;
    private float minX = 2;

    [Header("Camera Settings")]
    public float cameraSpeed;
    void Start()
    {
        CameraPosition = this.transform.position; 
    }

    // Update is called once per frame
    void Update()
        
    {
        Debug.Log(CameraPosition);
        Debug.Log(transform.position);
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x + cameraSpeed >= minX) {

            transform.Translate(new Vector3(-cameraSpeed, 0, 0));
            // transform.position.
            // transform.position.Set(transform.position.x + cameraSpeed / 10, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x -cameraSpeed <= maxX)
        {
           transform.Translate(new Vector3(cameraSpeed, 0, 0));
        }
    }
}
