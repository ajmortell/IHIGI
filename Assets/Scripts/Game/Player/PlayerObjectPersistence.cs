using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectPersistence : MonoBehaviour {

    public static PlayerObjectPersistence Instance;
   
    void Awake() {
        
        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
