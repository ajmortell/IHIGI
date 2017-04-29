using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Skill : MonoBehaviour {

    /*
     
        Skills are a way of gauging how well the player is doing in their jobs.
        and progression to a better life.

        They learn skills based on their respective positions in the job market.
        Working for a newspaper for instance will increase your writing skill.

        Higher skills increase your ability to answer job interview questions

        They also increase your ability to perform well while at the job
         
         */

    [HideInInspector]
    public int writing;
    [HideInInspector]
    public int drawing;
    [HideInInspector]
    public int building;
    [HideInInspector]
    public int arithmetic;
    [HideInInspector]
    public int comunication;
    [HideInInspector]
    public int enforcing;
    [HideInInspector]
    public int detecting;
    [HideInInspector]
    public int reading;
    [HideInInspector]
    public int logic;
    [HideInInspector]
    public int serving;
    [HideInInspector]
    public int studying;
    [HideInInspector]
    public int communication;
    [HideInInspector]
    public int pursuasion;
    [HideInInspector]
    public int accuracy;
    [HideInInspector]
    public int adaptability;
    [HideInInspector]
    public int analytics;
    [HideInInspector]
    public int attention;
    [HideInInspector]
    public int creativity;
    [HideInInspector]
    public int editing;
    [HideInInspector]
    public int comprehension;
    [HideInInspector]
    public int counseling;
    [HideInInspector]
    public int criticalThinking;
    [HideInInspector]
    public int defending;
    [HideInInspector]
    public int drama;
    [HideInInspector]
    public int driving;
    [HideInInspector]
    public int ethics;
    [HideInInspector]
    public int evaluation;
    [HideInInspector]
    public int expression;
    [HideInInspector]
    public int punctuality;
    [HideInInspector]
    public int gathering;
    [HideInInspector]
    public int leadership;
    [HideInInspector]
    public int handling;
    [HideInInspector]
    public int inspecting;
    [HideInInspector]
    public int listening;
    [HideInInspector]
    public int maintenace;
    [HideInInspector]
    public int management;
    [HideInInspector]
    public int motivator;
    [HideInInspector]
    public int navigation;
    [HideInInspector]
    public int negotiation;
    [HideInInspector]
    public int multiTasking;
    [HideInInspector]
    public int operation;
    [HideInInspector]
    public int patience;
    [HideInInspector]
    public int organization;
    [HideInInspector]
    public int performing;
    [HideInInspector]
    public int planning;
    [HideInInspector]
    public int prediction;
    [HideInInspector]
    public int potential;
    [HideInInspector]
    public int stamina;
    [HideInInspector]
    public int cooking;
    [HideInInspector]
    public int relaxation;
    [HideInInspector]
    public int painting;
    [HideInInspector]
    public int plumbing;
    [HideInInspector]
    public int mechanic;
    [HideInInspector]
    public int healing;
    [HideInInspector]
    public int caring;
    [HideInInspector]
    public int sense;
    [HideInInspector]
    public int curiosity;
    [HideInInspector]
    public int friendship;
    [HideInInspector]
    public int perseverance;
    [HideInInspector]
    public int responsible;
    [HideInInspector]
    public int humor;
    [HideInInspector]
    public int dancing;
    [HideInInspector]
    public int rhythm;
    [HideInInspector]
    public int dependability;
    [HideInInspector]
    public int emotion;
    [HideInInspector]
    public int interpersonal;
    [HideInInspector]
    public int adept;
    [HideInInspector]
    public int acute;
    [HideInInspector]
    public int ambition;
    [HideInInspector]
    public int assertion;
    [HideInInspector]
    public int competance;
    [HideInInspector]
    public int cooperation;
    [HideInInspector]
    public int deduction;
    [HideInInspector]
    public int dedication;
    [HideInInspector]
    public int diplomacy;
    [HideInInspector]
    public int empathy;
    [HideInInspector]
    public int innovation;
    [HideInInspector]
    public int intuition;
    [HideInInspector]
    public int loyalty;
    [HideInInspector]
    public int nonverbal;
    [HideInInspector]
    public int passion;
    [HideInInspector]
    public int perception;
    [HideInInspector]
    public int social;
    [HideInInspector]
    public int teaching;
    [HideInInspector]
    public int tracking;

    List<int> skillsList;

    void Awake() {
        writing = 4;
        drawing = 0;
        building = 0;
        arithmetic = 3;
        comunication = 0;
        enforcing = 0;
        detecting = 0;
        reading = 0;
        logic = 0;
        serving = 0;
        studying = 0;
        communication = 0;
        pursuasion = 0;
        accuracy = 0;
        adaptability = 0;
        analytics = 0;
        attention = 0;
        creativity = 0;
        editing = 0;
        comprehension = 0;
        counseling = 0;
        criticalThinking = 0;
        defending = 0;
        drama = 0;
        driving = 0;
        ethics = 0;
        evaluation = 0;
        expression = 0;
        punctuality = 0;
        gathering = 0;
        leadership = 0;
        handling = 0;
        inspecting = 0;
        listening = 0;
        maintenace = 0;
        management = 0;
        motivator = 0;
        navigation = 0;
        negotiation = 0;
        multiTasking = 0;
        operation = 0;
        patience = 0;
        organization = 0;
        performing = 0;
        planning = 0;
        prediction = 0;
        potential = 0;
        stamina = 0;
        cooking = 0;
        relaxation = 0;
        painting = 0;
        plumbing = 0;
        mechanic = 0;
        healing = 0;
        caring = 0;
        sense = 0;
        curiosity = 0;
        friendship = 0;
        perseverance = 0;
        responsible = 0;
        humor = 0;
        dancing = 0;
        rhythm = 0;
        dependability = 0;
        emotion = 0;
        interpersonal = 0;
        adept = 0;
        acute = 0;
        ambition = 0;
        assertion = 0;
        competance = 0;
        cooperation = 0;
        deduction = 0;
        dedication = 0;
        diplomacy = 0;
        empathy = 0;
        innovation = 0;
        intuition = 0;
        loyalty = 0;
        nonverbal = 0;
        passion = 0;
        perception = 0;
        social = 0;
        teaching = 0;
        tracking = 0;

        /* The following code bit finds all the fields (variables ^) in this class (Skill)
         * and prints them out. This can be used to check what skill is required to level
         * to keep code smaller. two methods should cover all skills.
         * IncreaseSkill() and DecreaseSkill()
        */
      //  System.Reflection.FieldInfo field;
        
        /*
        System.Reflection.FieldInfo[] rFI = this.GetType().GetFields();
        foreach (System.Reflection.FieldInfo rfi in rFI) {


            Debug.Log("RFI: " + rfi.Name);
        }  
        */  
    }

    public void increaseStat(System.Reflection.FieldInfo skill, int amt) {
        
    }

    public void decreaseStat(System.Reflection.FieldInfo skill, int amt) {

    }

    void Update () {
		
	}
}
