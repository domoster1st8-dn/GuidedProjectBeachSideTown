using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam;
    public Vector3 offset;

   

    // Update is called once per frame
    void LateUpdate()
    {
        cam.transform.position = transform.position + offset;
    }
}
