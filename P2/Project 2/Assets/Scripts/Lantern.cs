using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{ 

private RaycastHit hit;
public float range;
public List<ParticleSystem> particles = new List<ParticleSystem>();

// Use this for initialization
void Start()
{

}

// Update is called once per frame
void Update()
{
   Debug.DrawRay(transform.position, transform.forward * 100, Color.blue);
   if (Physics.Raycast(transform.position, transform.forward, out hit, range))
    {
        if (hit.collider.tag == "player")
        {
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].Play();
            }
        }
    }
}
}
