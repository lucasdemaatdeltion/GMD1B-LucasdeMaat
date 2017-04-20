using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour {

    public Vector3 move;
    public float hor;
    public float ver;
    public float speed;

    public GameObject hoofd;
    public Vector3 body;
    public Vector3 head;
    public Animator anim;
 
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(move * Time.deltaTime * speed);

        body.y = Input.GetAxis("Mouse X");
        head.x = -Input.GetAxis("Mouse Y");

        hoofd.transform.Rotate(head);
        transform.Rotate(body);

        move.x = hor;
        move.z = ver;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
    }
}
