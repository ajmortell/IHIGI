using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialGrid : MonoBehaviour {

    public GameObject CellPrefab = null;
 
    void Start() {

        for (int i = 0; i < 108; i++) {

            GameObject newCell = Instantiate(CellPrefab) as GameObject;
            newCell.transform.SetParent(this.gameObject.transform, false);
        }
      
    }
}

