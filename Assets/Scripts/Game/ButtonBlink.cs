using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ButtonBlink : MonoBehaviour {

    private GameObject blinkLblObj;
    private Image blinkBtnImg;
  
    void Awake() {
        blinkLblObj = gameObject;
        blinkBtnImg = blinkLblObj.GetComponent<Image>();
    }

    IEnumerator Blink() {
        while (true) {
            switch (blinkBtnImg.color.a.ToString()) {
                case "0":
                    blinkBtnImg.color = new Color(blinkBtnImg.color.r, blinkBtnImg.color.g, blinkBtnImg.color.b, 1);
                   
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    blinkBtnImg.color = new Color(blinkBtnImg.color.r, blinkBtnImg.color.g, blinkBtnImg.color.b, 0);

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
