using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDataManager : MonoBehaviour {
/*
    private int stat;
    private GameObject playerObject;
    private PlayerData playerData;
    private Skill skill;
    private Profession profession;

    private void Awake()
    {
        skillObject = gameObject;
        playerData = playerObject.GetComponent<PlayerData>();

         
    accuracy;    
    acute;    
    adaptability;   
    adept;    
    ambition;    
    analytics;    
    arithmetic;    
    assertion;   
    attention;    
    building;  
    caring;    
    communication;    
    competance;    
    comprehension;    
    comunication;    
    cooking;    
    cooperation;    
    counseling;    
    criticalThinking;    
    creativity;   
    curiosity;    
    dancing;    
    drama;   
    drawing;    
    dedication;    
    deduction;   
    defending;    
    dependability;    
    diplomacy;   
    detecting;    
    driving;    
    ethics;   
    evaluation;
    expression;   
    editing;    
    empathy;    
    emotion;    
    enforcing;  
    friendship;  
    gathering; 
    hindsight;    
    healing;   
    humor;    
    handling;  
    inspecting;  
    interpersonal;    
    innovation;    
    intuition;    
    interpreting;   
    loyalty;   
    lying;    
    leadership;   
    listening;    
    logic;    
    maintenace;   
    management;    
    motivator;
    multiTasking;   
    mechanic;  
    navigation;    
    negotiation;   
    nonverbal;  
    organization;   
    operation;   
    pursuasion;    
    punctuality;    
    patience;   
    performing;   
    planning;    
    prediction;    
    potential;    
    perseverance;    
    painting;    
    plumbing;    
    passion;   
    perception; 
    relaxation;
    responsible;
    rhythm;
    reading;
    serving;
    studying;
    stamina;
    sense;
    social;
    teaching;
    tracking;  
    writing;
}
    */

    public int increaseStat(int amt, string name) {
        int stat = 0;
        stat = stat + amt;
        return stat;
    }

    public int decreaseStat(int amt, string name) {
        int stat = 0;
        stat = stat - amt;
        return stat;
    }
}
