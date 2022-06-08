using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHP = 100;
    public static bool isGameOver;
    public TextMeshProUGUI playerHpText;
    public bool healingActive;
    public int radius = 2;
    public int healing = 10;

    private void Start()
    {
        healingActive = true;
        isGameOver = false;
        playerHP = 100;
    }

    void Update()
    {
        playerHpText.text = "%" + playerHP;
        if (isGameOver)
        {   
            SceneManager.LoadScene("Atlantis");
            playerHP = 100;
        }
    }

    public IEnumerator TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        if (playerHP <= 0)
            isGameOver = true;

        yield return new WaitForSeconds(1.5f);
    }
    public IEnumerator Heal(int healAmount)
    {
        healingActive = true;
        playerHP += healAmount;
        if (playerHP <= 150)
            healingActive = false;

        yield return new WaitForSeconds(1.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider nearbyObject in colliders)
            {
                if (nearbyObject.tag == "Trash")
                {
                    StartCoroutine(FindObjectOfType<PlayerHealth>().Heal(healing));
                }
            }


            this.enabled = false;
        }
    }
}
