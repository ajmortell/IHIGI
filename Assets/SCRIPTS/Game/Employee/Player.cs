using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string username;

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

    public enum StatType { MIND, CHARM, COURAGE, STRENGTH, LEARN, RISK};
    StatType statType;

    public bool hasStatChanged;

    public void increaseStat(int amt) {
        int statCheck = 0;//remove
        switch (statType) {

            case StatType.MIND:
                mind = mind + amt;
                statCheck = mind;//remove
                break;

            case StatType.CHARM:
                charm = charm + amt;
                statCheck = mind;//remove
                break;

            case StatType.COURAGE:
                courage = courage + amt;
                statCheck = mind;//remove
                break;

            case StatType.STRENGTH:
                strength = strength + amt;
                statCheck = mind;//remove
                break;

            case StatType.LEARN:
                learn = learn + amt;
                statCheck = mind;//remove
                break;

            case StatType.RISK:
                risk = risk + amt;
                statCheck = mind;//remove
                break;
        }
        print("STAT " + statType + " : " + statCheck);//remove
    }

    public void decreaseStat(int amt) {

        int statCheck = 0;//remove
        switch (statType) {

            case StatType.MIND:
                mind = mind - amt;
                statCheck = mind;//remove
                break;

            case StatType.CHARM:
                charm = charm - amt;
                statCheck = mind;//remove
                break;

            case StatType.COURAGE:
                courage = courage - amt;
                statCheck = mind;//remove
                break;

            case StatType.STRENGTH:
                strength = strength - amt;
                statCheck = mind;//remove
                break;

            case StatType.LEARN:
                learn = learn - amt;
                statCheck = mind;//remove
                break;

            case StatType.RISK:
                risk = risk - amt;
                statCheck = mind;//remove
                break;
        }
        print("STAT " + statType + " : " + statCheck);//remove
    }

    void Awake() {
    username="";

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

    hasStatChanged = false;
}

    void Start () {
		
	}
	
	void Update () {
		if (hasStatChanged == true) {
            // UPDATE STAT
            //increaseStat(2);
        }
	}
}