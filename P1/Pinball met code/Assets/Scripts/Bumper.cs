using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
    // Dit is de body die op je pinball zit.

    public Rigidbody pinball;
    // Dit zegt wanneer je iets aan raakt en wat er dan gebeurt. Hiermee komt er 10 score bij.

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().score += 10;
    }
}
