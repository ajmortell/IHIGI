using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerDataManager : MonoBehaviour {

    private int value;
    private GameObject playerObject;
    private StatData statData;
    private SkillData skillData;
    private ProfessionData professionData;

    private List<StatData> stats;
    private List<SkillData> skills;
    private List<ProfessionData> professions;

    private void Awake() {

        value = 0;
        playerObject = gameObject;
        statData = playerObject.GetComponent<StatData>();
        skillData = playerObject.GetComponent<SkillData>();
        professionData = playerObject.GetComponent<ProfessionData>();

        System.Reflection.FieldInfo[] skillFields = skillData.GetType().GetFields();
        foreach (System.Reflection.FieldInfo field in skillFields) {
            string stringValue = field.GetValue(skillData).ToString();
            value = System.Convert.ToInt32(stringValue);
            //Debug.Log("NAME: " + field.Name + " VALUE: " + value);
           
            //skillMenuItems.Add(new SkillMenuItem(field.Name, skillValueString));
        }
    }

    public int increaseStat(int amt, string name) {
     //   stat = stat + amt;
        return value;
    }

    public int decreaseStat(int amt, string name) {
       // stat = stat - amt;
        return value;
    }
}
