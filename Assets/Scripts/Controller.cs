using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody rb;
    AudioSource As;

    [SerializeField] ParticleSystem Gas1;
    [SerializeField] ParticleSystem Gas2;

    //[SerializeField] AudioClip Gas1sfx;
    //[SerializeField] AudioClip Gas2sfx;

    [SerializeField] bool SSP1;


    [SerializeField] float PowerOfMainThrust = 1f;
    [SerializeField] float PowerOfSideThrust = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        As = GetComponent<AudioSource>();
    }


    void Update()
    {
        ThrustMovement();       
    }

    void ThrustMovement()
    {
        if (SSP1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddRelativeForce(0, 1, 0 * PowerOfMainThrust * Time.deltaTime);
                Gas1.Play();
                if (!As.isPlaying) { As.Play(); }


            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(1, 0, 0 * PowerOfSideThrust * Time.deltaTime);

                //SoundClip
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(-1, 0, 0 * PowerOfSideThrust * Time.deltaTime);

                //SoundClip
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddRelativeForce(0, 1, 0 * PowerOfMainThrust * Time.deltaTime);
                Gas2.Play();
                if (!As.isPlaying) { As.Play(); }
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
}

