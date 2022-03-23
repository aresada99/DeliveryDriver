using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{



    [SerializeField] float steerSpeed = 220f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;


   
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerSpeed*steerAmount*Time.deltaTime);
        transform.Translate(0, moveSpeed*moveAmount* Time.deltaTime, 0);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;    
    }


    void OnTriggerEnter2D(Collider2D collision){
     
        if(collision.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }

    }




}
