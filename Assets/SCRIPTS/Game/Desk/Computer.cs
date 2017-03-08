using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Computer : MonoBehaviour {

    public void onComputerSelect(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
