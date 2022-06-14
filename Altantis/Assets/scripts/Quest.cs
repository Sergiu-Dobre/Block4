using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField] private Image customImage;



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            StartCoroutine(WaitBeforeShow());
            Debug.Log("is colliding");
            
        }


    }

    private IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(10);
        customImage.enabled = true;
        
    }
        

}
