using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    // Dit zijn de variabelen.

    public float power;
    public GameObject prefab;
    public GameObject spawnLocation;
    public bool spawnBall;

    // Wanneer "jump" wordt ingedrukt zal er een pinball spawnen.
    // Wanneer de levens kleiner dan 0 zijn zal er geen pinball spawnen en kun je niet verder spelen.
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager>().lives > 0)
            {
                if (spawnBall == false)
                {
                    SpawnPinball();
                }
                else print("Nothing");
            }
            else
            {
                print("GameOver");
            }

            spawnBall = true;
        }
    }
    // Hiermee wordt gezegt waar de bal moet spawnen.

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)(Instantiate(prefab, spawnLocation.GetComponent<Transform>().position, spawnLocation.GetComponent<Transform>().rotation));
        pinball.GetComponent<Rigidbody>().velocity = -transform.forward * power;
    }



}

