using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

	void OnCollisionEnter(Collision a)
    {
        Destroy(a.gameObject);
        GameObject.Find("GameManager").GetComponent<GameManager>().lives -= 1;
        GameObject.Find("Pinball kast nieuwste").GetComponent<Launcher>().spawnBall = false;
    }

}
