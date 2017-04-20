using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieDev : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Renderer r = GetComponent<Renderer>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;

            if (movie.isPlaying)
            {
                movie.Pause();
            }
            else
            {
                movie.Play();
            }
        }
    }
}