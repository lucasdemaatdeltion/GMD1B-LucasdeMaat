using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupObject : MonoBehaviour {
	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;
    public RaycastHit ray;
    public Vector3 target;
    public GameObject doel;
	// Use this for initialization
	void Start ()
    {
        //dit zorgt ervoor dat je main camera gezocht wordt.
		mainCamera = GameObject.FindWithTag("MainCamera");
        target = doel.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Hiermee wordt gechecked of heb object vast gehouden wordt en het anders op pakt.
		if(carrying) {
			carry(carriedObject);
			checkDrop();
			//rotateObject();
		} else {
			pickup();
		}
	}

	void rotateObject()
    {
        transform.LookAt(target);
		carriedObject.transform.Rotate(5,10,15);
	}

	void carry(GameObject o)
    {
        //hierbij kun je zeggen hoever het object opgepakt wordt en hoe smooth je het vast houdt.
		o.transform.position = Vector3.Lerp (o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
		o.transform.rotation = Quaternion.identity;
    }

	void pickup()
    {
        //wanneer je E indrukt pak je het object op en wordt het in het midden van je scherm geplaatst.
		if(Input.GetButtonDown("E")) 
            {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

            //hierbij wordt het object alleen opgepakt als het object het Pickupable script hebt.
			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
					//p.gameObject.rigidbody.isKinematic = true;
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
				}
			}
		}
	}

	void checkDrop()
    {
		if(Input.GetButtonDown ("E"))
        {
			dropObject();
		}
	}

	void dropObject()
    {
		carrying = false;
		//Nu wordt het object weer gedropt.
		carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
	}
}
