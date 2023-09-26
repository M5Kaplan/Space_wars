using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerP2 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]GameObject SpaceShip1;

    [SerializeField] float PowerOfMainThrust = 1f;
    [SerializeField] float PowerOfSideThrust = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        ThrustMovement();       
    }

    void ThrustMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(0, 1, 0 * PowerOfMainThrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(1, 0, 0 * PowerOfSideThrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-1, 0, 0 * PowerOfSideThrust * Time.deltaTime);
        }
    }
}

