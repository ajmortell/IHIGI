using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameDataManager : MonoBehaviour {

    public PlayerData LocalData;
    public bool IsSceneBeingLoaded = false;

    public void SaveData() {

        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.binary");

        //LocalData = PlayerState.Instance.localPlayerData;

        formatter.Serialize(saveFile, LocalData);

        saveFile.Close();
    }

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);

        LocalData = (PlayerData)formatter.Deserialize(saveFile);

        saveFile.Close();
    }
}
