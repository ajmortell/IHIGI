using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Travel : MonoBehaviour
{
    private List<Transform> waypoints;
    private List<Transform> previousWaypoints;
    private Transform waypoint;

    private float speed;
    
    #region AWAKE
    /* Region loads all available map waipoint objects into *waypoints* array */
    private void Awake() {
        speed = Random.Range(1.0f, 5.0f);
        waypoint = null;
        waypoints = new List<Transform>();
        previousWaypoints = new List<Transform>();
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
    #endregion

    IEnumerator SetupNext() {
        yield return new WaitForSeconds(12);
        waypoint = null;
    }

    Transform GetNearestWaypoint() {
        
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;// //
        Vector3 currentPosition = transform.position;
        
        foreach (Transform potentialTarget in waypoints) {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;// /
            if (dSqrToTarget < closestDistanceSqr) {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
                
            }
        }
        //print("CLOSEST WAYPOINT TO NPC: " + bestTarget);
        previousWaypoints.Add(bestTarget);
        waypoints.Remove(bestTarget);
        return bestTarget;

    }

    Transform GetNextNearestWaypoint(Transform closestPoint) {

        Transform nearestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = closestPoint.position;
        foreach (Transform potentialTarget in waypoints) {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr) {
                closestDistanceSqr = dSqrToTarget;
                nearestTarget = potentialTarget;
            }
        }
        //print("CLOSEST WAYPOINT TO NEAREST WAYPOINT: " + nearestTarget); 
        return nearestTarget;
    }

    public void GoToWaypoint() {

        if (waypoint == null) {
       
            Transform nearestPoint = GetNearestWaypoint();
            waypoint = GetNextNearestWaypoint(nearestPoint);    
            StartCoroutine(SetupNext());
        }
    }

    void moveNPC()
    {
        float dist = Vector2.Distance(waypoint.transform.position, transform.position);
        transform.position = Vector2.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);
    }

    void LateUpdate() {
        
        GoToWaypoint();
        moveNPC();
    }
}
