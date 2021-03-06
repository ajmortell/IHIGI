﻿using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class LblBlink : MonoBehaviour {
    
    private GameObject blinkLblObj;
    private Text blinkLbl;
    
	void Awake () {
        blinkLblObj = gameObject;
        blinkLbl = blinkLblObj.GetComponent<Text>();
    }

    IEnumerator Blink() {
        while (true) {
            switch (blinkLbl.color.a.ToString()) {
                case "0":
                    blinkLbl.color = new Color(blinkLbl.color.r, blinkLbl.color.g, blinkLbl.color.b, 1);
                    
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    blinkLbl.color = new Color(blinkLbl.color.r, blinkLbl.color.g, blinkLbl.color.b, 0);
                    
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }

    private void OnEnable() {
        StartBlinking();
    }

    private void OnDisable() {
        StopBlinking();
    }

    void StartBlinking() {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking() {
        StopAllCoroutines();
    }
}
