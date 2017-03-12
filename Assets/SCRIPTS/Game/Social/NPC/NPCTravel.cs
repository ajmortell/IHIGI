using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NPCTravel : MonoBehaviour {
       
    private List<Transform> waypoints;
    private Transform waypoint; 
    private int nextPoint;
    private float speed;

    private void Awake() {

        nextPoint = 0;
        speed = Random.Range(1.0f, 10.0f);
        waypoint = null;
        waypoints = new List<Transform>();
        AddNPCs();
    }

    public void AddNPCs() {
        GameObject[] waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");
        foreach (GameObject obj in waypointObjects) {
            AddTarget(obj.transform);
        }
    }

    public void AddTarget(Transform target) {
        waypoints.Add(target);
    }
    
    public void DistanceToTarget() {
        waypoints.Sort(delegate (Transform t1, Transform t2) {
            return Vector3.Distance(t1.transform.position, transform.position).CompareTo(Vector3.Distance(t2.transform.position, transform.position));
        });

    }

    public void GoToWaypoint() {

        if (waypoint == null) {

            DistanceToTarget();
            waypoint = waypoints[0];
        }
    }

    void LateUpdate() {
        
        GoToWaypoint();
        float dist = Vector2.Distance(waypoint.transform.position, transform.position);
        transform.position = Vector2.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);

    }
}
