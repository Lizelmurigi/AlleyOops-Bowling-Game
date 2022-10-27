using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMover : MonoBehaviour
{

    //We create an instance of a rigidbody, that will be used as link between our script asset and unity to manipulate our game object.
    //Class instance_name = new Constructor();-->Java
    public Rigidbody rb;

    //we declared two Camera objects for the Main Camera and the Aerial camera

    public Camera MainCamera;
    public Camera AerialCamera;
    public Camera SideCamera;

    // Start is called before the first frame update
    void Start()
    {
        //initialize the camera states here
        MainCamera.enabled = true;
        AerialCamera.enabled = false;
        SideCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        //We capture key inputs for switching in between the cameras
        if (Input.GetKey(KeyCode.L))
        {
            MainCamera.enabled = true;
            AerialCamera.enabled = false;
            SideCamera.enabled = false;
        }
        if (Input.GetKey(KeyCode.M))
        {
            MainCamera.enabled = false;
            AerialCamera.enabled = true;
            SideCamera.enabled = false;
        }

        if (Input.GetKey(KeyCode.N))
        {
            MainCamera.enabled = false;
            AerialCamera.enabled = false;
            SideCamera.enabled = true;
        }

    }
}
