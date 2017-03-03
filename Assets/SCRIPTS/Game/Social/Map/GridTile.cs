using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridTile : MonoBehaviour {

    private float width;
    private float height;
    private int tileId;
    public GameObject self = null;
    private Image tileImage;

    void Awake () {
        self = gameObject;
        tileImage = self.GetComponent<Image>();
        tileImage.color = Color.clear;
        
        print("TILE AWAKE: " + self.name);
        
    }

    IEnumerator Fader()
    {
        print("WAIT 1");
        tileImage.color = Color.magenta;
        tileImage.CrossFadeAlpha(0, 0.5f, false);
        yield return new WaitForSeconds(0.5f);
        print("WAIT 2");
        tileImage.CrossFadeAlpha(1, 0.5f, false);
    }
	
    public void OnClick()
    {
        
        
        StartCoroutine(Fader());
        print("CLICKED");


    }
	
}
