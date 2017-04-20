using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool inConvo;
    public int eventNumber;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void EventStart()
    {
        
        if (eventNumber == 1)
        {
            Event1();
        }
        if (eventNumber == 2)
        {
            Event2();
        }
        if (eventNumber == 3)
        {
            Event3();
        }
    }

    void Event1()
    {
        //Hiermee kun je door een bepaalde deur heen.
        print("You obtained a crowbar");
    }
    void Event2()
    {
        //Nu moet je langs de guards komen.
        print("You made your way trough the guards");
    }
    void Event3()
    {
        //Hiermee kun door de grond heen en de guards ontwijken.
        print("You have found a shovel");
    }
}
