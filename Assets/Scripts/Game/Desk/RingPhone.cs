using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingPhone : MonoBehaviour {

    public bool testBool_isCalling;
    private Vector3 startPos, toPos;
    public Animator animator;

    void Awake () {
        animator = gameObject.GetComponent<Animator>();   
        testBool_isCalling = false;
    }

    // Update is called once per frame
    void Update() {

        // eventual isCalling value will be set by events when the user receives a call
        if (Input.GetKeyDown("p")) {
            testBool_isCalling = true;
        }
        if (Input.GetKeyUp("p")) {
            testBool_isCalling = false;
        }

        if (testBool_isCalling == true) {
            animator.SetBool("isReceiving", true);
            print("RING ... RING ... RING . . . . . .");
        } else {
            animator.SetBool("isReceiving", false);
            print(" . . . . . . HUNG UP.");
        }
    }
}
