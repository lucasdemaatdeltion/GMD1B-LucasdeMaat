using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class PauseGame : MonoBehaviour {
    public Transform canvas;
    public Transform Player;
    public Transform pauseMenu;
    public Transform soundsMenu;
    public Transform videoSettinggsMenu;
    public Transform controlsMenu;
    SaveGame saveGame;

	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Pause();
        }
	}

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            if(pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                soundsMenu.gameObject.SetActive(false);
                videoSettinggsMenu.gameObject.SetActive(false);
                controlsMenu.gameObject.SetActive(false);
            }
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<First_person>().enabled = false;
            saveGame = gameObject.GetComponent<SaveGame>();
            saveGame.SaveGameSettings(false);
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<First_person>().enabled = true;
        }
    }

    public void Sounds(bool open)
    {
        if (open)
        {
            soundsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!open)
        {
            soundsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
    public void VideoSettings(bool open)
    {
        if (open)
        {
            videoSettinggsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!open)
        {
            videoSettinggsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
    public void Controls(bool open)
    {
        if (open)
        {
            controlsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!open)
        {
            controlsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
}
