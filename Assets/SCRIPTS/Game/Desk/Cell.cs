using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cell : MonoBehaviour {

    public void onCellPress(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
