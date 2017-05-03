using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCars : MonoBehaviour {

    public GameObject vehicles = null;
    public Transform objpos;
    public float speed = 0.0f;

	void Start () {
        
        objpos = vehicles.transform;   
    }

	void Update () {
        objpos.Translate(Vector2.right * speed);
    }
}
