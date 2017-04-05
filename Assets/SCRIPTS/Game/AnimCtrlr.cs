using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AnimCtrlr : MonoBehaviour {
    
    void Awake() {
    
        StartCoroutine( WaitThenLoadScene(7) );
    }

    IEnumerator WaitThenLoadScene(int scene) {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(scene);
    }
}
