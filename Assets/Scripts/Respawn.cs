using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject SpaceShip1_Prefab;
    private GameObject SpaceShip1_Current;

    [SerializeField] GameObject SpaceShip2_Prefab;
    private GameObject SpaceShip2_Current;

    Vector3 StartingPositionP1 = new Vector3(0, 1.25f, -20);
    Vector3 StartingPositionP2 = new Vector3(0, 1.25f, 20);
    void Start()
    {
        SpawnP1();
        SpawnP2();
    }
    void Update()
    {
        Respawn_();
    }
    void Respawn_()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (SpaceShip1_Current == null)
            {
                SpawnP1();
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (SpaceShip2_Current == null)
            {
                SpawnP2();
            }
        }
    }
    void SpawnP1()
    {
        SpaceShip1_Current = Instantiate(SpaceShip1_Prefab, StartingPositionP1, Quaternion.identity);

    }
    void SpawnP2()
    {
        SpaceShip2_Current = Instantiate(SpaceShip2_Prefab, StartingPositionP2, Quaternion.identity);
    }

}
