using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour {

    public int level;

    public int mind;
    public int charm;
    public int luck;
    public int strength;

    private Skill skillSlotA;
    private Skill skillSlotB;
    private Skill skillSlotC;
    private Skill skillSlotD;

    // private Clothing outfit;

    public int learn;
    public int risk;

    public int focus;
    public int energy;
    public string username;

    public bool hasStatChanged;

    public int[] oldValues;
    public int[] newValues;

    void Awake() {

    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}