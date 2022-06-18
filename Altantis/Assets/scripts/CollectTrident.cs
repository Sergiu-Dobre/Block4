using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectTrident : MonoBehaviour

{

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (other.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                ScoringSystem.theScore += 1;
            }

        } 


 

    }
}
