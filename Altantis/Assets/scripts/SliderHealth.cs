using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHealth : MonoBehaviour
{
    public PlayerHealth playerhealth;
    public Image fill;
    private Slider sliderone;
    // Start is called before the first frame update
    void Awake()
    {
        sliderone = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = playerhealth.playerHP;
        sliderone.value = fillValue;
    }
}


