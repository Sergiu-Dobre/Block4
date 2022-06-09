using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject Questmarker;
    public GameObject Questicon;

    [SerializeField] private Compass comppasSscrip;
    [SerializeField] private QuestMarker questScript;

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

        }
    }
}
