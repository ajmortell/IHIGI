using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class GlobalControl : MonoBehaviour {

    [HideInInspector] public static GlobalControl Instance;

    [HideInInspector] public StatData savedStatData;
    [HideInInspector] public StatData LocalCopyOfStatData;
    [HideInInspector] public SkillData savedSkillData;
    [HideInInspector] public SkillData LocalCopyOfSkillData;
    [HideInInspector] public ProfessionData savedProfessionData;
    [HideInInspector] public ProfessionData LocalCopyOfProfessionData;

    public GameObject playerObject;
    [HideInInspector] public bool IsSceneBeingLoaded = false;

    void Awake() {

        savedStatData = gameObject.AddComponent<StatData>();
        savedSkillData = gameObject.AddComponent<SkillData>();
        savedProfessionData = gameObject.AddComponent<ProfessionData>();

        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        } else if (Instance != this) {
            Destroy(gameObject);
        }
    } 

    public void SaveData() {

        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.binary");

        LocalCopyOfStatData = PlayerState.Instance.localStatData;
        formatter.Serialize(saveFile, LocalCopyOfStatData);
        LocalCopyOfSkillData = PlayerState.Instance.localSkillData;
        formatter.Serialize(saveFile, LocalCopyOfSkillData);
        LocalCopyOfProfessionData = PlayerState.Instance.localProfessionData;
        formatter.Serialize(saveFile, LocalCopyOfProfessionData);
        
        saveFile.Close();
    }

    public void LoadData() {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);
        LocalCopyOfStatData = (StatData)formatter.Deserialize(saveFile);
        LocalCopyOfSkillData = (SkillData)formatter.Deserialize(saveFile);
        LocalCopyOfProfessionData = (ProfessionData)formatter.Deserialize(saveFile);

        saveFile.Close();
    }
}
