using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectTrident : MonoBehaviour

{

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F)) 
        {
            Destroy(gameObject);
            ScoringSystem.theScore += 1;
          
        }


 

    }
}
