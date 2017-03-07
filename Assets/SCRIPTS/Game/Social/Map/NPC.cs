using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

    public GameObject npc;
    Transform npcTransform;

	private void Awake () {
        npc = GetComponent<GameObject>();
        npc = gameObject;
        npcTransform = gameObject.transform;
        //print("++++//~~~~~~~~~~~~ NPC NAME: "+npc.name);
	}
	

	private void Update () {
		
	}
}
