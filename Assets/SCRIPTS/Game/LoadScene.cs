using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
 
    void Awake() {
    }

    private IEnumerator loadWait(int scene) {
        yield return new WaitForSeconds(0.0f);
        SceneManager.LoadScene(scene);
    }

    public void loadScene(int scene) { 
        StartCoroutine(loadWait(scene));
    }

}
