using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class GlobalControl : MonoBehaviour {

    [HideInInspector]
    public static GlobalControl Instance;
    [HideInInspector]
    public PlayerData savedPlayerData;
    //[HideInInspector]
    //public Skill savedSkills;
    public GameObject Player;

    void Awake() {
        savedPlayerData = gameObject.AddComponent<PlayerData>();
        //savedSkills = gameObject.AddComponent<Skill>();

        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        else if (Instance != this) {
            Destroy(gameObject);
        }
    }

    [HideInInspector]
    public PlayerData LocalCopyOfData;
    [HideInInspector]
    public bool IsSceneBeingLoaded = false;

    public void SaveData() {
        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.binary");
        LocalCopyOfData = PlayerState.Instance.localPlayerData;
        formatter.Serialize(saveFile, LocalCopyOfData);
        saveFile.Close();
    }

    public void LoadData() {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);
        LocalCopyOfData = (PlayerData)formatter.Deserialize(saveFile);
        saveFile.Close();
    }
}
