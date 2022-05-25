using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    private Transform FiringPoint;

    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private float firingSpeed;

    [SerializeField]
    private PlayerGun Instance;

    private float LastTimeShot = 0;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            shoot();
        }
    }

    public void shoot()
    {
        if (LastTimeShot + firingSpeed <= Time.time)
        {
            LastTimeShot = Time.time;
            Instantiate(projectilePrefab, FiringPoint.position, transform.rotation);
        }
    }
}

