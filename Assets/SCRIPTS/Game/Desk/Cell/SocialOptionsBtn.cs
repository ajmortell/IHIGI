using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialOptionsBtn : MonoBehaviour {

    public int index;
    private Button socialOptionsBtn;
    // Use this for initialization
    void Start () {
        socialOptionsBtn = GetComponent<Button>();
        socialOptionsBtn.onClick.AddListener(() => action(index));
    }

    void action(int idx)
    {
        //Debug.Log("Button pressed :  " + idx);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
