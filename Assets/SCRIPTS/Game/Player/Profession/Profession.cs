using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///  this is the type of basic profession classes the user can be

public class Profession : MonoBehaviour {

    public enum ProfessionType
    {
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

    public enum ProfessionSubType
    {
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


    public int academics = 0;
    public int arts = 0;
    public int business = 0;
    public int industry = 0;
    public int medical = 0;
    public int politics = 0;
    public int science = 0;
    public int service = 0;

    void Awake() {

    }

    void Start() {

    }

    void Update() {

    }

}
