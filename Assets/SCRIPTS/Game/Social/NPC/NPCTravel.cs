using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class NPCTravel : MonoBehaviour {
    
    private GameObject[] waypointObjects;// list of the game objects that are waypoints
    private List<Transform> waypoints;
    private Transform singlewWaypoint; // a single waypoint transform 

    private GameObject npcObject;
    
    private int endPoint = 0;

    private void Awake() {

        waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");
        waypoints = new List<Transform>();

        npcObject = gameObject; 

        foreach (GameObject waypoint in waypointObjects) {
            
            singlewWaypoint = waypoint.transform;
            waypoints.Add(singlewWaypoint);
          
        }   
        
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (waypoints.Count == 0) {
            return;
        }
        // Set the agent to go to the currently selected destination.
        npcObject.transform.localPosition = waypoints[endPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        endPoint = (endPoint + 1) % waypoints.Count;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(4.0f);
        GotoNextPoint();
    }

    void LateUpdate()
    {
        //npcObjects = GameObject.FindGameObjectsWithTag("npc");
        //print("npcObjects length: " + npcObjects.Length);
        //foreach (GameObject npc in npcObjects) {
        //    npcs.Add(npc);
        //    print("NPC COUNT ADDED TO LIST: " + npcs.Count);
            StartCoroutine(wait());
        //}
        
    }
}
