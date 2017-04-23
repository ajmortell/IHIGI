using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string firstName;
    public string lastName;

    public int level;
    public int focus;
    public int energy;
    public int cash;

    public int mind;
    public int charm;
    public int courage;
    public int strength;
    public int learn;
    public int risk;

    public bool hasStatChanged;
    
    void Awake() {
    firstName ="Player";
    lastName="One";
    level=0;
    focus=0;
    energy=0;
    cash=0;
    mind=0;
    charm=0;
    courage=0;
    strength=0;
    learn=0;
    risk=0;
    hasStatChanged=false;
    
    }

    void Update() {
        if (hasStatChanged == true) {
            // UPDATE STAT
            //increaseStat(2);
        }
    }
}