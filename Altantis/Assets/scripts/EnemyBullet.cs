using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Vector3 FiringPoint;

    public int damageAmount = 15;

    [SerializeField]
    private float ProjectileSpeed;

    [SerializeField]
    private float maxProjectileDistance;

   

    void Start()
    {
        FiringPoint = transform.position;
    }

    void Update()
    {
        MoveProjectile();
    }

    void MoveProjectile()
    {
        if (Vector3.Distance(FiringPoint, transform.position) > maxProjectileDistance)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * ProjectileSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.GetComponent<PlayerHealth>().currenthealth -= 30;
            PlayerHealth.TakeDamage(damageAmount);
            Destroy(this.gameObject);
        }
    }

}