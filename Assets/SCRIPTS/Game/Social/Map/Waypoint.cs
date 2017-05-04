using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Waypoint : MonoBehaviour {

    //private Transform waypointTranform;
    public GameObject self;

    // Use this for initialization
    void Awake () {
        self = gameObject;
        //waypointTranform = self.transform;
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.clear;
        Gizmos.DrawSphere(self.transform.position, 0.5f);

    }
}
