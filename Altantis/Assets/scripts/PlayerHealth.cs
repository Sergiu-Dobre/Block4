using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHP = 100;
    public static bool isGameOver;


    private void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            SceneManager.LoadScene("Atlantis");
        }
    }

    public static void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        if (playerHP <= 0)
            isGameOver = true;
    }

}
