using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateText : MonoBehaviour {
    public AnimateText() { }
    private string str;
    
    void Start() {
        StartCoroutine(animateText("Pretty cool text"));
    }

    IEnumerator animateText(string strComplete)
    {
        int i = 0;
        str = "";
        while (i < strComplete.Length) {
            str += strComplete[i++];
            yield return new WaitForSeconds(0.5F);
        }
    }
}
