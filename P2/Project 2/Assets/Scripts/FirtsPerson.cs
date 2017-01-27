using UnityEngine;
using System.Collections;

public class FirtsPerson : MonoBehaviour {
    public Vector3 kijken;
    public Vector3 camkijken;
    public GameObject cam;
    public float mousespeed;

    public Vector3 v3;
    public float hor;
    public float ver;
    public float speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        kijken.y = Input.GetAxis("Mouse X");
        camkijken.x = -Input.GetAxis("Mouse Y");
        cam.transform.Rotate(camkijken * Time.deltaTime * mousespeed);
        transform.Rotate(kijken * Time.deltaTime * mousespeed);
    }

    void FixedUpdate()
    {
       hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v3.x = hor;
        v3.z = ver;

        transform.Translate(v3 * Time.deltaTime * speed);

    }
} 