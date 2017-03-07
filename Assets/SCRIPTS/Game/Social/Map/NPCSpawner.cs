﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NPCSpawner : MonoBehaviour {

    public GameObject MapPanel;
    public GameObject NPCObject;
    private List<GameObject> NPCPool;    
    private Vector2 spawnValues;
    private int NPCCount;
    private float spawnWait;
    private float startWait;
    private float mobWait;

    private void Awake() {
        MapPanel = gameObject;
        
        NPCCount = 1;
        StartCoroutine(WaitThenSpawnMob());
    }

    IEnumerator WaitThenSpawnMob() {

        yield return new WaitForSeconds(startWait);

        while (true) {
            // Pos Ranges
            spawnValues.x = Random.Range(0, 128);
            spawnValues.y = Random.Range(0, 96);   
            // Timers
            spawnWait = Random.Range(1, 4);
            startWait = Random.Range(1, 4);
            mobWait = Random.Range(1, 4);
        
            for (int i = 0; i < NPCCount; i++) {

                //Instantiate(NPCObject, Vector2(Random.Range(minY,maxY), Random.Range(minX,maxX)), Quaternion.identity)

                Vector2 spawnPos = new Vector2(spawnValues.x, spawnValues.y);
                //Vector2 spawnPos = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(NPCObject, spawnPos, spawnRotation);
                NPCObject.transform.SetParent(MapPanel.transform);

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(mobWait);
            
        }
    }

    IEnumerator SpawnSingleNPC(float timer, bool spawn)
    {
        while (spawn == true)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 spawnPos = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(NPCObject, spawnPos, spawnRotation);
                yield return new WaitForSeconds(timer);
            }
            //NPCPool.Add(NPCObject);
            //print("NPC POOL COUNT" + NPCPool.Count);
            yield return new WaitForSeconds(timer);
            spawn = false;
        }
    }

   

    private void Update() {

    }
}
