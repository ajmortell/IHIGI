using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public GameObject npc;
    Transform npcTransform;
    private SpriteRenderer npcImage;
    private int mind;
    private int strength;
    private int heart;
    private float npcFocus;
    private float npcEnergy;

    private void Awake () {
        //npc = GetComponent<GameObject>();
        npc = gameObject;
        npcTransform = npc.transform;
        npcFocus = 40.0f;
        npcEnergy = 80.0f;
        
        //print("++++//~~~~~~~~~~~~ NPC POS: " + npcTransform.position);
	}


    public void decrementNPCFocus(int value) {
        if (npcFocus != 0) {
            npcFocus = npcFocus - value;
        }
    }

    public void decrementNPCFocusOverTime() {
       
        if (npcFocus <= 0) {
            npcFocus = 0;
            //Debug.Log("NPC FOCUS: " + npcFocus);
            StartCoroutine(fadeNPC());
        } else {
            npcFocus -= 0.05f * Time.deltaTime;
           // Debug.Log("NPC FOCUS: " + npcFocus);
        }
    }

    public float getNPCFocus() {
        return npcFocus;
    }

    IEnumerator fadeNPC()
    {
        npcImage = npc.GetComponent<SpriteRenderer>();
        npcImage.color = Color.yellow;
        yield return new WaitForSeconds(1.0f);
        Color tmp = npcImage.GetComponent<SpriteRenderer>().color;     
        tmp.a = 0.25f;
        npcImage.GetComponent<SpriteRenderer>().color = tmp;
        yield return new WaitForSeconds(1.0f);
        Destroy(npc);
    }

    public void setNPCFocus(float value) {
        npcFocus = value;
    }

    private void Update() {

        if (npcFocus != 0) {
            decrementNPCFocusOverTime();
        }
    }
}
