using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    public GameObject Questmarker;
    public GameObject Questicon;

    [SerializeField] private Compass comppasSscrip;
    [SerializeField] private QuestMarker questScript;

   

    private void Update()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {

            // destroy this object.
            comppasSscrip.completeQuest(questScript.idQuest);
            //  Destroy(Questmarker);
            //  Destroy(Questicon);
            Questicon.SetActive(false);
            Questmarker.SetActive(false);
            //this works for 3 trash ~things~
            
        }

    }
}
