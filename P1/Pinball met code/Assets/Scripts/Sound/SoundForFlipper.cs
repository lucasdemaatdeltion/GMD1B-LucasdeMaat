using UnityEngine;
using System.Collections;

public class SoundForFlipper : MonoBehaviour
{
    // Dit geeft aan waar hij het geluid kan vinden.
    AudioSource audio;

    // Dit zegt dat hij de audio source moet gebruiken.

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Wanneer je contact met het object maakt zal het geluid afspelen.

    void OnCollisionEnter(Collision collision)
    {

        // Play a sound if the colliding objects had a big impact.		
        if (collision.relativeVelocity.magnitude > 2)
            audio.Play();

    }
}
