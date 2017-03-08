using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Outside : MonoBehaviour {

    public void onOutsideSelect(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
