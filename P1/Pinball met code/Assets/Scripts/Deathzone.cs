using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour
{
    
    // Dit zegt wanneer je iets aan raakt en wat er dan gebeurt. 
    // Hiermee zegt de deathzone dat de pinball weg moet en er één leven af gaat. 
    // Het zegt ook dat de extra ball verdwijnt.
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Pinball")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().lives -= 1;
            GameObject.Find("Flipperkast op scholl compleet").GetComponent<Launcher>().spawnBall = false;
        }
        else if (col.gameObject.tag == "Extraball")
        {

        }

        Destroy(col.gameObject);
    }

}