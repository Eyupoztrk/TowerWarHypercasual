using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Joystick _joystick;
    public GameObject handle;
    public float speed;
    public Camera camera;

    private void Update()
    {
     //   float x = _joystick.Horizontal;
     if (Input.GetMouseButton(0))
     {
        
         Vector3 mousePosition = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane));
         transform.position = new Vector3(mousePosition.x*speed, transform.position.y, transform.position.z);
         Debug.Log(mousePosition.x);
     }
     

        //transform.Translate(new Vector3(x*speed*Time.deltaTime,0,0));
    }
}
