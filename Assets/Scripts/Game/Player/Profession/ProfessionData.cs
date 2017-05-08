using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///  this is the type of basic profession classes the user can be

public class ProfessionData : MonoBehaviour {

    [HideInInspector]
    public enum ProfessionType {
        UNEMPLOYED =0,
        ACADEMICS =1,
        ARTS =2,
        BUSINESS =4,
        INDUSTRY =5,
        MEDICAL =6,
        POLITICS =7,
        SCIENCE =8,
        SERVICE =9,
    };

    [HideInInspector]
    public enum ProfessionSubType {
        ACCOUNTING,//INDUSTRY
        BUILDING,//INDUSTRY
        EDUCATION,//SERVICE
        ENGINEERING,//SCIENCE
        ENTERTAINMENT,//ARTS
        GOVERNMENT,//SERVICE/POLITICS
        LANGUAGE,//ACADEMICS
        LAW,// SERVICE
        MARKETING,// BUSINESS
        MUSIC,// ARTS
        NEWS,// ARTS/SERVICE
        SALES,// INDUSTRY/BUSINESS
        SOFTWARE,// SCIENCE
    };

    [HideInInspector] public ProfessionType professionType;
    [HideInInspector] public ProfessionSubType professionSubType;
    [HideInInspector] public int academics = 0;
    [HideInInspector] public int arts = 0;
    [HideInInspector] public int business = 0;
    [HideInInspector] public int industry = 0;
    [HideInInspector] public int medical = 0;
    [HideInInspector] public int politics = 0;
    [HideInInspector] public int science = 0;
    [HideInInspector] public int service = 0;
}
