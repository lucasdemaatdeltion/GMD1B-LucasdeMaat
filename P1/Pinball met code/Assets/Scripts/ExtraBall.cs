using UnityEngine;
using System.Collections;

public class ExtraBall : MonoBehaviour
{
    // dit zijn de variabelen.

    public float power;
    public GameObject prefab;
    public GameObject spawnLocation;
    public bool extraBall;

    // Dit zegt wanneer je iets aan raakt en wat er dan gebeurt.
    // Wanneer er geen extra bal is en hij aangeraakt wordt dan komt er één extra bal in het veld.

    void OnCollisionEnter()
    {
            if (extraBall == false)
            {
                Spawnextraball();
                extraBall = true;
            }
    }


    // Hiermee wordt gezegt waar de bal moet spawnen.

    void Spawnextraball()
    {
        GameObject pinball = (GameObject)(Instantiate(prefab, spawnLocation.GetComponent<Transform>().position, spawnLocation.GetComponent<Transform>().rotation));
        pinball.GetComponent<Rigidbody>().velocity = -transform.forward * power;
    }
}




