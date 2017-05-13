using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour {

	public void onButtonPress(int value) {
        SceneManager.LoadScene(value);
    }
}
