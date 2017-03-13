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
        GatherWaypoints();
    }

    public void GatherWaypoints() {
        GameObject[] waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");
        foreach (GameObject obj in waypointObjects) {
            AddWaypoint(obj.transform);
        }
    }

    public void AddWaypoint(Transform target) {
        waypoints.Add(target);
    }
    
    public void DistanceToTarget() {
        waypoints.Sort(delegate (Transform t1, Transform t2) {
            return Vector2.Distance(t1.transform.position, transform.position).CompareTo(Vector2.Distance(t2.transform.position, transform.position));
        });

    }

    IEnumerator SetupNext() {
        yield return new WaitForSeconds(5);
        waypoint = null;
    }

    public void GoToWaypoint() {

        if (waypoint == null) {
            nextPoint = (nextPoint +1)% waypoints.Count;
            DistanceToTarget();
            waypoint = waypoints[nextPoint];
            print("WAYPOINT NEXT POINT: " + waypoints[nextPoint]);
            StartCoroutine(SetupNext());
        }
    }

    void LateUpdate() {
        
        GoToWaypoint();
        float dist = Vector2.Distance(waypoint.transform.position, transform.position);
        transform.position = Vector2.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);

    }
}
