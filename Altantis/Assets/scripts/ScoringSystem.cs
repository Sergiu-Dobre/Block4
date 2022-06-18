using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;



    void Update()
    {
        scoreText.GetComponent<Text>().text = "Trident parts collected = " + theScore;
        if (theScore >= 3)
        {   //create Gameover scene
            SceneManager.LoadScene("MainMenu");
            Debug.Log("done");
        }
    }





}

