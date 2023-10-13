using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] float amlitude = 1f;
    [SerializeField] float frequency = 2f;
    [SerializeField] float Yoffset;

   
    void Update()
    {
        float newY = Yoffset + amlitude * Mathf.Sin(frequency * Time.time);
        transform.position = new Vector3(transform.position.x, newY , transform.position.z);
    }


}
