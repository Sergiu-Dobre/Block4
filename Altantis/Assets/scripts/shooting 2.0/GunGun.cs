
using UnityEngine;

public class GunGun : MonoBehaviour
{
    public float damage=10f;
    public float range=100f;

    public Camera MainCamera;
    public ParticleSystem muzzle;
    public GameObject bullet;
    public Transform pewpew;
    public float shootSpeed = 1000f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            GameObject currentBullet = Instantiate(bullet, pewpew.position, pewpew.rotation);
            Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

            rig.AddForce(transform.forward * shootSpeed, ForceMode.Impulse);
        }
    }
    public void Shoot()
    {
        muzzle.Play();
        
        RaycastHit hit;
       if( Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward,out hit, range))
            {

          
            Debug.Log(hit.transform.name);

           Target target= hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

        }
    }
}
