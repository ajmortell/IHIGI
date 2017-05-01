using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

/*
    public enum StatType { MIND, CHARM, COURAGE, STRENGTH, LEARN, RISK };
    StatType statType;

    private PlayerData player;

    void Awake() {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<PlayerData>();
        increaseStat(3,StatType.CHARM);
    }

    public void increaseStat(int amt, StatType type) {
        int statCheck = 0;//remove
        switch (type) {
            case StatType.MIND:
                player.mind = player.mind + amt;
                statCheck = player.mind;//remove
                break;

            case StatType.CHARM:
                player.charm = player.charm + amt;
                statCheck = player.mind;//remove
                break;

            case StatType.COURAGE:
                player.courage = player.courage + amt;
                statCheck = player.courage;//remove
                break;

            case StatType.STRENGTH:
                player.strength = player.strength + amt;
                statCheck = player. strength;//remove
                break;

            case StatType.LEARN:
                player.learn = player.learn + amt;
                statCheck = player. learn;//remove
                break;

            case StatType.RISK:
                player.risk = player.risk + amt;
                statCheck = player. risk;//remove
                break;
        }
        print("STAT " + statType + " : " + statCheck);//remove
    }

    public void decreaseStat(int amt, StatType type) {

        int statCheck = 0;//remove
        switch (statType) {
            case StatType.MIND:
                player.mind = player.mind - amt;
                statCheck = player.mind;//remove
                break;

            case StatType.CHARM:
                player.charm = player.charm - amt;
                statCheck = player.charm;//remove
                break;

            case StatType.COURAGE:
                player.courage = player.courage - amt;
                statCheck = player. courage;//remove
                break;

            case StatType.STRENGTH:
                player.strength = player.strength - amt;
                statCheck = player. strength;//remove
                break;

            case StatType.LEARN:
                player.learn = player.learn - amt;
                statCheck = player. learn;//remove
                break;

            case StatType.RISK:
                player.risk = player.risk - amt;
                statCheck = player. risk;//remove
                break;
        }
        print("STAT " + statType + " : " + statCheck);//remove
    }

    void Update() {
        if (player.hasStatChanged == true) {
            // UPDATE STAT
            //increaseStat(2);
        }
    }
    */

}
