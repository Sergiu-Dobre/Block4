using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScript : MonoBehaviour
{
    bool detected;
    GameObject target;
    public Transform enemy;

    public GameObject bullet;
    public Transform shootpoint;
    public GameObject Player;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forwardSpeed;

    public float shootSpeed = 10f;
    public float timeToShoot = 1.3f;
    float originalTime;

    float x;
    float y;
    float z;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
       
        originalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
      
        //Matrix4x4.TRS(this,Quaternion.LookRotation(Player.transform,Vector3.up));
        if (detected)
        {
            enemy.LookAt(target.transform);
        }
    }

    private void FixedUpdate()
    {
        if (detected)
        {
            timeToShoot -= Time.deltaTime;
            rb.AddForce(transform.forward * forwardSpeed, ForceMode.Acceleration);
            if (timeToShoot < 0)
            {
                ShootPlayer();
                timeToShoot = originalTime;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;
        }
    }

    private void ShootPlayer()
    {
            GameObject currentBullet = Instantiate(bullet, shootpoint.position, shootpoint.rotation);
            Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

            rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
    }
}
