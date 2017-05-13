using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleAnimController : MonoBehaviour {

    Animator animator;
    public bool isTimeToChange;

    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 5.0f;
    public GameObject cycleObject;
    public SpriteRenderer cycleSprite;

    
    void Awake() {
        
        animator = GetComponent<Animator>();
        isTimeToChange = false;
    }

    public void changeSkyToTime() {

    }

    public void fadeFrameToNext() {

    }

    void Update() {
      //isTimeToChange = ...
    }
}
