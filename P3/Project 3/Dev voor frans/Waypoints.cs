using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Waypoints : MonoBehaviour
{
    public enum State
    {
        Patrol,
        idle,
        chasing,
    }
    public enum State2
    {
        waypoint1,
        waypoint2,
        waypoint3,
        waypoint4,
    }

    public Vector3 way1;
    public Vector3 way2;
    public Vector3 way3;
    public Vector3 way4;

    public GameObject way01;
    public GameObject way02;
    public GameObject way03;
    public GameObject way04;

    public State guardstate;
    public State2 waypoints;

    public float speed;

    public GameObject player;
    public RaycastHit hit;
    public int range;

    private Transform target = null;

    private float minRange;

    public Transform doel;
    public Transform myTransform;

    private float closedBy;

    public List<GameObject> dichtsteBij = new List<GameObject>();

    public RaycastHit dichtbij;



    void FixedUpdate()
    {
        if (guardstate == State.Patrol)
        {
            Walking();

            if(transform.position == way1)
            {
                waypoints = State2.waypoint2;
            }
            if (transform.position == way2)
            {
                waypoints = State2.waypoint3;
            }
            if (transform.position == way3)
            {
                waypoints = State2.waypoint4;
            }
            if (transform.position == way4)
            {
                waypoints = State2.waypoint1;
            }
        }

        if (guardstate == State.chasing)
        {
            if (target == null) return;
            transform.LookAt(target);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }

        if (guardstate == State.idle)
        {

        }
    }

    void Start()
    {
        waypoints = State2.waypoint1;
        guardstate = State.Patrol;
        way1 = way01.transform.position;
        way2 = way02.transform.position;
        way3 = way03.transform.position;
        way4 = way04.transform.position;
        dichtsteBij.Add(way01);
        dichtsteBij.Add(way02);
        dichtsteBij.Add(way03);
        dichtsteBij.Add(way04);
    }

    void Walking()
    {
        if(waypoints == State2.waypoint1)
        {
            transform.position = Vector3.MoveTowards(transform.position, way1, speed * Time.deltaTime);
            transform.LookAt(way1);
        }
        if (waypoints == State2.waypoint2)
        {
            transform.position = Vector3.MoveTowards(transform.position, way2, speed * Time.deltaTime);
            transform.LookAt(way2);
        }
        if (waypoints == State2.waypoint3)
        {
            transform.position = Vector3.MoveTowards(transform.position, way3, speed * Time.deltaTime);
            transform.LookAt(way3);
        }
        if (waypoints == State2.waypoint4)
        {
            transform.position = Vector3.MoveTowards(transform.position, way4, speed * Time.deltaTime);
            transform.LookAt(way4);
        }
    }
    // --------------------------------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") target = other.transform;
        guardstate = State.chasing;
    }

    void OnTriggerExit(Collider other)
    {
        closedBy = 10000000;
        if (other.tag == "Player") target = null;
        if (Vector3.Distance(transform.position, way1) < closedBy)
        {
            closedBy = Vector3.Distance(transform.position, way1);
            waypoints = State2.waypoint1;
        }
        if (Vector3.Distance(transform.position, way2) < closedBy)
        {
            closedBy = Vector3.Distance(transform.position, way2);
            waypoints = State2.waypoint2;
        }
        if (Vector3.Distance(transform.position, way3) < closedBy)
        {
            closedBy = Vector3.Distance(transform.position, way3);
            waypoints = State2.waypoint3;
        }
        if (Vector3.Distance(transform.position, way4) < closedBy)
        {
            closedBy = Vector3.Distance(transform.position, way4);
            waypoints = State2.waypoint4;
        }
        Debug.DrawRay(transform.position, transform.forward * 2, Color.blue);
        if (Physics.Raycast(transform.position, transform.forward, out dichtbij, 2))
        {
            if (gameObject.tag == ("Player"))
            {
                guardstate = State.idle;
            }
        }
        else
        {
            guardstate = State.Patrol;
        }
    }
}