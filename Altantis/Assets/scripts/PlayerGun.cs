using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    Transform FiringPoint;

    [SerializeField]
    GameObject projectilePrefab;

    [SerializeField]
    float firingSpeed;

    public static PlayerGun Instance;

    private float LastTimeShot = 0;

    void Awake ()
    {
        Instance = GetComponent<PlayerGun>();
    }

    public void shoot()
    {
        if (LastTimeShot + firingSpeed <= Time.time)
        {
            LastTimeShot = Time.time;
            Instantiate(projectilePrefab, FiringPoint.position, FiringPoint.rotation);
        }
    }
}

