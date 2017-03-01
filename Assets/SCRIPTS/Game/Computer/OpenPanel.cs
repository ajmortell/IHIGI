using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel = null;
    public bool isOpen = false;
    public bool canOpen = true;

    void Awake()
    {
        panel = GameObject.Find("StartMenuPanel");
        panel.SetActive(false);
    }

    public void onStartMenuPress()
    {
        if (canOpen == true)
        {
            Debug.Log("Panel Open");
            isOpen = true;
            canOpen = false;
            panel.SetActive(true);

        } else {

            Debug.Log("Panel Close");
            isOpen = false;
            canOpen = true;
            panel.SetActive(false);
        }

    }
}
