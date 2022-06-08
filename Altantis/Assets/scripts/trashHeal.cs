using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashHeal : MonoBehaviour
{
    
    public float radius = 2;
    public int healing = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           

            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider nearbyObject in colliders)
            {
                if (nearbyObject.tag == "Player")
                {
                    StartCoroutine(FindObjectOfType<PlayerHealth>().Heal(healing));
                }
            }

                
            this.enabled = false;
        }
    }

}

