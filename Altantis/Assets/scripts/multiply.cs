using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiply : MonoBehaviour
{ 
    public GameObject fishVarinat;
    static int fishNo = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < fishNo; i++)
        {
            Instantiate(fishVarinat, transform.position + (transform.right * 1f), transform.rotation);
            Instantiate(fishVarinat, transform.position + (transform.right * 0.5f), transform.rotation);
            Instantiate(fishVarinat, transform.position + (transform.up * 0.5f), transform.rotation);
            Instantiate(fishVarinat, transform.position + (transform.up * 1f), transform.rotation);
            Instantiate(fishVarinat, transform.position + (transform.right * 1.5f), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
}
