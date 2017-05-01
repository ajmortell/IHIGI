using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    public static PlayerState Instance;
    public PlayerData localPlayerData = new PlayerData();

    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
        if (Instance != this) {
            Destroy(gameObject);
        }
        GlobalControl.Instance.Player = gameObject;
    }

    void Start()  {
        localPlayerData = GlobalControl.Instance.savedPlayerData;
    }

    void Update() {

    }
}
