using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotTurning : MonoBehaviour
{
    [SerializeField] int SpinningSpeed;
    [SerializeField] bool SpinRight;



    void Start()
    {

    }

    void Update()
    {
        SpinningMovement();
    }

    private void SpinningMovement()
    {
        if (SpinRight)
        {
            transform.Rotate(Vector3.right, Time.deltaTime * SpinningSpeed);
        }
        else
        {
            transform.Rotate(-Vector3.right, Time.deltaTime * SpinningSpeed);
        }
    }
}
