using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    //public GameObject loadingImage = null;
    //public bool isActive;

    public void loadScene(int scene) {
        // loadingImage.SetActive(isActive);
        SceneManager.LoadScene(scene);
    }

}
