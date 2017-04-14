using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_person : MonoBehaviour {

    public Vector3 bodyX;
    public Vector3 camX;
    public GameObject cam;
    public GameObject body;
    public float hoofd;


    void Update()
    {
        camX.x = -Input.GetAxis("Mouse Y");
        {
            cam.transform.Rotate(camX);
        }
        bodyX.y = Input.GetAxis("Mouse X");
        {
            body.transform.Rotate(bodyX);
        }
    }

}