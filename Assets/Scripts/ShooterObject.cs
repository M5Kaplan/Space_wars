using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterObject : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Transform firePoint;

    [SerializeField] float fireRate = 3f;
    [SerializeField] float projectileSpeed = 1.0f;



    void Start()
    {
        StartCoroutine(FireCoroutine());
    }

    private IEnumerator FireCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireRate);
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject Gun = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = Gun.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * projectileSpeed;

        Destroy(Gun,7f );
    }
}
