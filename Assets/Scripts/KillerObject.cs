using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerObject : MonoBehaviour
{
    private bool isCooldown = true;

    [SerializeField] float Cooldown = 5f;
    [SerializeField] float SpinSpeed = 5f;

    private MeshRenderer mR;
    private Collider collide;



    private void Start()
    {
        mR = GetComponent<MeshRenderer>();
        collide = GetComponent<Collider>();
    }
    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Rotate(0, 1, 0 * Time.deltaTime * SpinSpeed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isCooldown)
        {
            switch (collision.gameObject.tag)
            {
                case "Player1":
                    DestroyPlayer2();                   
                    VisibleKiller();

                    break;
                case "Player2":
                    DestroyPlayer1();
                    VisibleKiller();
                    break;
            }
        }
    }

        void DestroyPlayer2()
    {
        GameObject player2 = GameObject.FindGameObjectWithTag("Player2");

        if (player2 != null)
        {
            Destroy(player2);
            Debug.Log("Player2 destroyed");
        }
    }

    void DestroyPlayer1()
    {
        GameObject player1 = GameObject.FindGameObjectWithTag("Player1");

        if (player1 != null)
        {
            Destroy(player1);
            Debug.Log("Player1 destroyed");
        }
    }
    void VisibleKiller()
    {
       
        if (mR != null)
        {
            mR.enabled = false;
        }
        if (collide != null)
        {
            collide.enabled = false;
        }
        isCooldown = false;
        StartCoroutine(RespawnCooldown());
    }
    IEnumerator RespawnCooldown()
    {
        yield return new WaitForSeconds(Cooldown);

        isCooldown = true;
        mR.enabled = true;
        collide.enabled = true;
        Debug.Log("Killer is back");
        
    }
}
