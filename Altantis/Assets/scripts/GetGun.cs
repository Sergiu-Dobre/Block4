using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGun : MonoBehaviour

{
    public GameObject GameObject;



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            GameObject.SetActive(true);
            Debug.Log("is colliding");

        }


    }
}
