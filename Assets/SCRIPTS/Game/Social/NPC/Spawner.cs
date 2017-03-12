﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Spawner : MonoBehaviour
{
    private List<Transform> waypoints;
    private Transform waypoint;  

    public GameObject MapPanel;
    public GameObject NPCObject;

    private Vector2 spawnValues;
    private float spawnWait;
    private float startWait;
    private float mobWait;

    private List<Transform> spawnpoints;

    // STARTUP
    private void Awake() {
        MapPanel = gameObject;
        waypoints = new List<Transform>();
        CollectWaypoints();
        StartCoroutine(Spawn());
    }

    public void CollectWaypoints() {
        GameObject[] waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");
        foreach (GameObject obj in waypointObjects) {
            AddWaypointToList(obj.transform);
        }
    }

    public void AddWaypointToList(Transform point) {
        waypoints.Add(point);

    }

    IEnumerator Spawn() {

        yield return new WaitForSeconds(startWait);

        bool stopSpawn = false;
        while (stopSpawn == false) {
        
            spawnWait = Random.Range(1, 4);
            startWait = Random.Range(1, 2);
            mobWait = Random.Range(1, 2);

            for (int i = 0; i < 1; i++) {
                spawnValues = waypoints[Random.Range(0, waypoints.Count)].localPosition;
                Vector2 spawnPos = new Vector2(spawnValues.x, spawnValues.y);
                print("" + "++++//~~~~~~~~~~~~ SPAWN POS: " + spawnPos + "");

                Quaternion spawnRotation = Quaternion.identity;
                GameObject newItem = Instantiate(NPCObject, spawnPos, spawnRotation);
                newItem.transform.SetParent(MapPanel.transform);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(mobWait);
            stopSpawn = true;
        }
    }

}