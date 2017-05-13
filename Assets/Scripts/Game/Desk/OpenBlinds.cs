using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBlinds : MonoBehaviour {

    public GameObject panel = null;
    private string Name = "BlindsPanel";
    private bool canOpen = true;
    RectTransform panelRect;

    void Awake() {
        panel = GameObject.Find(Name);
        panel.SetActive(true);
        panelRect = panel.GetComponent<RectTransform>();
    }

    public IEnumerator shrinkBlind() {
    
        for (int i =0; i < 32; i++)  {
            yield return new WaitForSeconds(0.025f);
            panelRect.sizeDelta = new Vector2(panelRect.rect.width, panelRect.rect.height -1);
            panelRect.localPosition = new Vector2(panelRect.localPosition.x, panelRect.localPosition.y +1);
        }
        panel.SetActive(false);
    }

    public IEnumerator expandBlind() {

        panel.SetActive(true);
        for (int i = 0; i < 32; i++) {
            yield return new WaitForSeconds(0.025f);
            panelRect.sizeDelta = new Vector2(panelRect.rect.width, panelRect.rect.height +1);
            panelRect.localPosition = new Vector2(panelRect.localPosition.x, panelRect.localPosition.y -1);
        }        
    }

    public void OnBtnPress() {
        if (canOpen == true) {
            canOpen = false;
            StartCoroutine(shrinkBlind());          
        } else {
            canOpen = true;
            StartCoroutine(expandBlind());         
        }
    }
}