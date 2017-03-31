using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour {

    private Animator anim;
    private SpriteRenderer scannerSprite;
    public GameObject self = null;

    private List<GameObject> npcs;

    void Start () {
        scannerSprite = self.GetComponentInChildren<SpriteRenderer>();
        scannerSprite.material.color = Color.clear;
        anim = scannerSprite.GetComponent<Animator>();
        npcs = new List<GameObject>();
        
    }

    public void CollectNPCs(Transform t, Vector2 size) {
        GameObject[] npcObjects = GameObject.FindGameObjectsWithTag("npc");
        foreach (GameObject obj in npcObjects) {
         
            //if (true) {

                AddNPCToScanList(obj);
            //}
        }
    }

    public void AddNPCToScanList(GameObject npc) {
        npcs.Add(npc);
        print("NPCs IN SCAN AREA: " + npcs.Count);
    }

    IEnumerator Scan(Transform t, Vector2 size) {

        CollectNPCs(t,size);
        yield return new WaitForSeconds(1.0f);

        print("SCANNING..................................");
        


    }

    IEnumerator AnimateScanner() {
        scannerSprite.material.color = Color.magenta;
        yield return new WaitForSeconds(0.2f);
    }

    public void OnScan(Transform t, Vector2 size) {
        anim.SetBool("scanON", true);
        StartCoroutine(AnimateScanner());
        print("SCANNED TILE X: " + t.localPosition.x + " Y: " + t.localPosition.y + " SIZE: " + size);
        StartCoroutine(Scan(t,size));
    }

	void Update () {
		
	}
}
