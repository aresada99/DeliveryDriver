using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject car;

    void Start()
    {
        
    }

   
    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(2,2,-0.3f);
    }
}
