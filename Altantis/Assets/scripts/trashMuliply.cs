using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashMuliply : MonoBehaviour
{
    public GameObject prefab;
    static int fishNo = 10;
    public static GameObject[] everyFish = new GameObject[fishNo];
    public static Vector3 goalPos = Vector3.zero;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 10f);

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
