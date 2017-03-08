using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NPCSpawner : MonoBehaviour {

    public GameObject MapPanel;
    public GameObject NPCObject;
    private List<GameObject> NPCPool;    
    private Vector2 spawnValues;
    private float spawnWait;
    private float startWait;
    private float mobWait;

    private void Awake() {
        MapPanel = gameObject;
        StartCoroutine(WaitThenSpawnMob());
    }

    IEnumerator WaitThenSpawnMob() {

        yield return new WaitForSeconds(startWait);
        bool stopSpawn = false;
        //while (stopSpawn == false) {
        while (true)
        {
            // Pos Ranges
            spawnValues.x = Random.Range(0,128);
            spawnValues.y = Random.Range(0,96);
            // Timers
            spawnWait = Random.Range(1, 4);
            startWait = Random.Range(1, 2);
            mobWait = Random.Range(1, 2);
        
            for (int i = 0; i < 1; i++) {

                Vector2 spawnPos = new Vector2(spawnValues.x-64, spawnValues.y-48);
                //print("++++//~~~~~~~~~~~~ SPAWN POS: " + spawnPos);

                Quaternion spawnRotation = Quaternion.identity;
                GameObject newItem = Instantiate(NPCObject, spawnPos, spawnRotation);
                newItem.transform.SetParent(MapPanel.transform);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(mobWait);
            stopSpawn = true;
        }
    }

    IEnumerator SpawnSingleNPC(float timer, bool spawn) {
        while (spawn == true)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 spawnPos = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(NPCObject, spawnPos, spawnRotation);
                yield return new WaitForSeconds(timer);
            }
            yield return new WaitForSeconds(timer);
            spawn = false;
        }
    }

    private void Update() {

    }
}
