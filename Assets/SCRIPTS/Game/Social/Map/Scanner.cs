using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour {

    private Animator anim;
    private SpriteRenderer scannerSprite;
    public GameObject self = null;

    // Use this for initialization
    void Start () {
        scannerSprite = self.GetComponentInChildren<SpriteRenderer>();
        scannerSprite.material.color = Color.clear;
        anim = scannerSprite.GetComponent<Animator>();
    }

    IEnumerator AnimateScanner()
    {

        scannerSprite.material.color = Color.magenta;
        yield return new WaitForSeconds(0.2f);
    }

    public void OnScan()
    {
        anim.SetBool("scanON", true);
        StartCoroutine(AnimateScanner());
    }

	// Update is called once per frame
	void Update () {
		
	}
}
