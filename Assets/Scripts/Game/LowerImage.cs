using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerImage : MonoBehaviour {

    public Transform target;
    private float speed = 20f;
  
    void Start() {      
    }

    void Update() {
      
        if (transform.position != target.position) {
            print("MOVING : " + transform.position);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }

    }
}
