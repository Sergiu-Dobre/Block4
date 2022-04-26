using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV : MonoBehaviour
{ 

    public float mouseDPI = 100f;
    public Transform pBody;
    float rotationX = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //we are hiding and locking the cursor while we are in game 
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseDPI * Time.deltaTime;
        //rotation on X or Y(mouse) won't be afected by frames 
        float mouseY = Input.GetAxis("Mouse Y")*mouseDPI*Time.deltaTime;

        rotationX -= mouseY;
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        //clamping the rotation

        pBody.Rotate(Vector3.up * mouseX);
       
    }
}
