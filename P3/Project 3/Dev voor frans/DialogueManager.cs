using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    public RaycastHit hit;
    public int length;
    public GameObject playerCamara;
    public Transform canvas;
    public Transform player;
    public bool convo;
    public int vragenreeks;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Wanneer je in range bent en je op E drukt zal de canvas aan gaan, de tijd stil staan, de first person script uit en een bool aan gaan.
        Debug.DrawRay(player.transform.position, player.transform.forward * length, Color.blue);
		if (Physics.Raycast(player.transform.position, player.transform.forward, out hit, length))
        {
            if (Input.GetButtonDown("E"))
            {
                if (hit.collider.GetComponent<Dialogue>()!= null)
                {
                    canvas.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    player.GetComponent<First_person>().enabled = false;
                    canvas.GetComponent<UIManager>().nameString = hit.collider.GetComponent<Dialogue>().naam;
                    convo = true;

                }
            }
        }

        if (convo == true)
        {
            InConversation();
        }
	}

    public void AnswerYes()
    {
        //Hiermee wordt er +1 op de teller gedaan die ondertussen ook gechecked wordt bij de event checker.
        vragenreeks += 1;
        hit.collider.GetComponent<Dialogue>().EventCheck();
    }

    public void AnswerNo()
    {
        //Hiermee wordt er +2 op de teller gedaan die ondertussen ook gechecked wordt bij de event checker.
        vragenreeks += 2;
        hit.collider.GetComponent<Dialogue>().EventCheck();
    }

    void InConversation()
    {
        //hierbij wordt de vragenreeks gecheckt door de list wanneer dit niet gebeurt dan gaat de canvas uit, de tijd aan, first person script aan en de bool uit.
        if (vragenreeks < hit.collider.GetComponent<Dialogue>().tekst.Count)
        {
            canvas.GetComponent<UIManager>().activeString = hit.collider.GetComponent<Dialogue>().tekst[vragenreeks];
        }
        else
        {
            canvas.GetComponent<UIManager>().activeString = (" ");
            canvas.GetComponent<UIManager>().nameString = (" ");
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            player.GetComponent<First_person>().enabled = true;
            convo = false;
            vragenreeks = 0;
        }
    }
}
