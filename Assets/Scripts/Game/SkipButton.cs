using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour {

	public void onButtonPress(int value) {
        print("BUTTON PRESSED SKIP SCENE");
        SceneManager.LoadScene(value);
    }
}
