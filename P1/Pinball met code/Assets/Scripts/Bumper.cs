using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

    public Rigidbody pinball;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().score += 10;
    }
}
