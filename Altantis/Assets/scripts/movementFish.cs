using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementFish : MonoBehaviour
{
    public GameObject prefab;
    static int fishNo = 5;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < fishNo; i++)
        {
           
            Instantiate(prefab, transform.position + (transform.right * 1f), transform.rotation);
        }

    }

    // Update is called once per frame

    void Update()
    {
        
          
    }
}
