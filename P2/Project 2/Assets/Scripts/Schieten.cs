using UnityEngine;
using System.Collections;

public class Schieten : MonoBehaviour
{
    private RaycastHit hit;
    public float force;
    public GameObject prefab;
    public GameObject spawnLocation;
    public Animation open;
    public bool gateOpen;

    void Update()
    {
            print("testray");
        Debug.DrawRay(transform.position, transform.forward*100, Color.blue);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            
            if (hit.collider.tag == "sleutel")
            {
                if(gateOpen == false)
                {
                    open.Play();
                    gateOpen = true;
                }
            }   
        }      
       }
}
