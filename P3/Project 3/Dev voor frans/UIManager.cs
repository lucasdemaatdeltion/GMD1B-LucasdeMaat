using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text textwindow;
    public Text characterName;
    public string activeString;
    public string nameString;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        characterName.text = nameString;
        textwindow.text = activeString;

	}
}
