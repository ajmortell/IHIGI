using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpawn : MonoBehaviour {

    public GameObject npc;
    //Transform npcTransform;
    private SpriteRenderer npcImage;
    private float sleep;
    private int mind;
    private int strength;
    private int heart;
    private float npcFocus;
    private float npcEnergy;

    public bool isNPCVisible;

    private void Awake () {
        //npc = GetComponent<GameObject>();
        npc = gameObject;
        //npcTransform = npc.transform;
        npcFocus = Random.Range(5.0f, 40.0f);
        npcEnergy = Random.Range(0.01f,0.05f);
        //print("++++//~~~~~~~~~~~~ NPC ENERGY: " + npcEnergy);
	}


    public void decrementNPCFocus(int value) {
        if (npcFocus != 0) {
            npcFocus = npcFocus - value;
        }
    }

    public void decrementNPCFocusOverTime() {
       
        if (npcFocus <= 0) {
            npcFocus = 0;
            StartCoroutine(fadeNPC());
        } else {
            npcFocus -= npcEnergy * Time.deltaTime;
            //Debug.Log("NPC FOCUS: " + npcFocus);
        }
    }

    public float getNPCFocus() {
        return npcFocus;
    }

    IEnumerator fadeNPC() {
        npcImage = npc.GetComponent<SpriteRenderer>();
        npcImage.color = Color.grey;
        Color tmp = npcImage.GetComponent<SpriteRenderer>().color;
        tmp.a = 0.5f;
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
