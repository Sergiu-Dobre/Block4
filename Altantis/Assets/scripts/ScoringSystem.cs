using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;



    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Trident parts collected = " + theScore;
        if (theScore >= 3)
        {   //create Gameover scene
            SceneManager.LoadScene("FinalCutscene");
            Debug.Log("done");
        }
    }





}

