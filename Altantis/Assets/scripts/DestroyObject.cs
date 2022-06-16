using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    public GameObject Questmarker;
    public GameObject Questicon;
    public int count;

    [SerializeField] private Compass comppasSscrip;
    [SerializeField] private QuestMarker questScript;

    private void Start()
    {
        count = 0;
    }

    private void Update()
    {
      

    }
    void OnTriggerEnter(Collider other)
    {
        count += 1;
        if (other.gameObject.tag == "Player") 
        {
           
            // destroy this object.
            comppasSscrip.completeQuest(questScript.idQuest);
            //  Destroy(Questmarker);
            //  Destroy(Questicon);
            Questicon.SetActive(false);
            Questmarker.SetActive(false);

            if (count >= 4 )
            {
                SceneManager.LoadScene("MainMenu");
                Debug.Log("done");
            }
        }
        
    }
}
