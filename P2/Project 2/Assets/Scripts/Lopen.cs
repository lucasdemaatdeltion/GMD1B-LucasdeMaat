using UnityEngine;
using System.Collections;

public class Lopen : MonoBehaviour {
    public Vector3 move;
    public float hor;
    public float ver;
    public float speed;

    public GameObject hoofd;
    public Vector3 body;
    public Vector3 head;
    public Rigidbody player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
