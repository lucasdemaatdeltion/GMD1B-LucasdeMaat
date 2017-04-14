using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

    public List<string> tekst = new List<string>();
    public string naam;
    public int stringNumberDialogue;
    public GameObject managers;
    public int event1;
    public int event2;
    public int event3;
    

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    public void EventCheck()
    {
        //hierbij wordt alles gechecked of het event 1, 2 of 3 is.
        if (managers.GetComponent<DialogueManager>().vragenreeks == event1)
        {
            managers.GetComponent<GameManager>().eventNumber = event1;
        }
        if (managers.GetComponent<DialogueManager>().vragenreeks == event2)
        {
            managers.GetComponent<GameManager>().eventNumber = event2;
        }
        if (managers.GetComponent<DialogueManager>().vragenreeks == event3)
        {
            managers.GetComponent<GameManager>().eventNumber = event3;
        }
        managers.GetComponent<GameManager>().EventStart();
    }
}
