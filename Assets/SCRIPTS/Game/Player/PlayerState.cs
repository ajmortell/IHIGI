using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    public static PlayerState Instance;

    public StatData localStatData = new StatData();
    public SkillData localSkillData = new SkillData();
    public ProfessionData localProfessionData = new ProfessionData();
    
    void Awake() {
        if (Instance == null) {
            Instance = this;
        }
        if (Instance != this) {
            Destroy(gameObject);
        }
        GlobalControl.Instance.playerObject = gameObject;
    }

    void Start()  {
        localStatData = GlobalControl.Instance.savedStatData;
        localSkillData = GlobalControl.Instance.savedSkillData;
        localProfessionData = GlobalControl.Instance.savedProfessionData;
    }
}
