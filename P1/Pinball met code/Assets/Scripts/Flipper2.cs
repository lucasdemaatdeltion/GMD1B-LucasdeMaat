using UnityEngine;
using System.Collections;

public class Flipper2 : MonoBehaviour
{
    // dit zijn de variabelen.

    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge;

    // Dit is voor de hinge joint om de juiste center te pakken.
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.zero;
        hinge = GetComponent<HingeJoint>();

    }

    // Hiermee wordt gezegt dat "Fire2" ingedrukt moet zijn voor de actie.
    // Dit is voor de inspector (hierin kun je zeggen hoe veel kracht de flipper heeft).
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 f = transform.up * flipperStrength;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
    }
}
