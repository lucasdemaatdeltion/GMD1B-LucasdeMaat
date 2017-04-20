using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOptionsOnly : MonoBehaviour
{
    public Transform soundsMenu;
    public Transform canvas;

    public void Sounds(bool open)
    {
        if (open)
        {
            soundsMenu.gameObject.SetActive(true);
            canvas.gameObject.SetActive(false);
        }
        if (!open)
        {
            soundsMenu.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
        }
    }
}
